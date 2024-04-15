#pragma warning disable 0649
using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField]
    string _nodeName;
    public string Name => _nodeName;
    [SerializeField, PropertyTooltip("The message to display when a user logs in. Use $username to display the username. Leaving it blank will use default")]
    string _loginMessage = "Welcome back $username";
    public string LoginMessage => _loginMessage == "" ? "Welcome back $username" : _loginMessage;
    public int LoginAttempts {get; set;}
    [SerializeField]
    int power = 10;
    int Power => power;
    [SerializeField]
    string hardware;
    public string Hardware => hardware;
    [SerializeField]
    string software;
    public string Software => software;
    [SerializeField, ReadOnly]
    GameProcess _currentProcess;
    public event Action<GameProcess> OnStartProcess;
    public event Action<GameProcess> OnEndProcess;
    public event Action<GameProcess> OnTickProcess;
    public GameProcess CurrentProcess { get => _currentProcess; set => _currentProcess = value; }
    public bool PausingForInput => CurrentProcess.RequiresUserInput;

    public bool IsBusy => !CurrentProcess.IsIdle;
    User _currentUser;
    public User CurrentUser {
        get {
            if(_currentUser == null || _currentUser.Username == "")
                _currentUser = _users.First(u => u.Username == "Guest");
            return _currentUser;
        }set {
            _currentUser = value;
    }}
    public Permission Role => _users.MaxBy(u => (float)u.Role).Role;
    [SerializeField]
    List<User> _users;
    public List<User> Users => _users;


    [SerializeField, ReadOnly]
    List<GameFile> files;
    public List<GameFile> Files => files;
    [SerializeField, ReadOnly]
    List<Connection> connections;
    [SerializeField]
    int security = 30;
    public int Security => security;
    [SerializeField]
    List<Hacks> adminVulnerabilities;
    public List<Hacks> AdminVulnerabilities => adminVulnerabilities;
    [SerializeField]
    List<Hacks> rootVulnerabilities;
    public List<Hacks> RootVulnerabilities => rootVulnerabilities;
    public string ElevateRole(Permission perm)
    {
        if(_currentUser.Username == "Guest"){
            var newUser = new User(){Username = Terminal.Username, Role = perm, PlayerHasAccess = true};
            _users.Add(newUser);
            _currentUser = newUser;
            return $"User {newUser.Username} created with role {newUser.Role}";
        }
        _currentUser.Role = perm;
        return "";
    }
    public void StartProcess(GameProcess process)
    {
         if (process == null || process.IsIdle)
            return;
        _currentProcess = process;
        OnStartProcess?.Invoke(_currentProcess);
    }
    void RunProcess()
    {
        if (_currentProcess == null || _currentProcess.IsIdle || _currentProcess.RequiresUserInput)
            return;
        _currentProcess.WorkDone += Power * Time.deltaTime;
        var program = GetFile(_currentProcess.ProgramPath) as GameProgram 
            ?? throw new Exception($"Program {_currentProcess.ProgramPath} not found");
        var result = program.TickProcess(_currentProcess);
        if (result != "") {
            Terminal.T.TryPrint(result);
        }
        OnTickProcess?.Invoke(_currentProcess);

        if(_currentProcess.IsComplete)
        {
            program.CompleteProcess(_currentProcess);
            EndProcess();
            _currentProcess = new GameProcess() { IsIdle = true};
        }
    }
    public void EndProcess()
    {
        if(_currentProcess.IsIdle)
            return;
        OnEndProcess?.Invoke(_currentProcess);
        _currentProcess = new GameProcess() { IsIdle = true };
    }
    
    public void AddFile(GameFile file)
    {
        files.Add(file);
        if(file is GameDaemon daemon){
            daemon.Node = this;
        }
        file.transform.SetParent(transform);
    }
    public void RemoveFile(GameFile file)
    {
        files.Remove(file);
        file.RM();
    }
    public GameFile GetFile(string path){
        var isGlobal = path.Contains(":");
        if(isGlobal){
            var (nodeName, fileName, _) = path.Split(":");
            return GetGlobalFile(path);
        }
        return GetLocalFile(path);
    }
    public static GameFile GetGlobalFile(string path, string fileType = "file", bool sudo = false){
        var isGlobal = path.Contains(":");
        if(!isGlobal)
            return null;
        var (nodeName, fileName, _) = path.Split(":");
        return GraphManager.GetNode(nodeName).GetLocalFile(fileName);
    }
    public GameFile GetLocalFile(string fileName, bool sudo = false, bool allowNull = false){
        var file = files.Find(f => f.MatchesName(fileName));
        if(file == null && !allowNull)
            throw new TerminalError($"File {fileName} not found");
        if (!sudo && !CurrentUser.Role.HasPermission(file.permissionRequired))
            throw new TerminalError($"Permission denied to access {file.FileName}");
        return file;
    }

    public bool IsLocal(GameFile file) => files.Contains(file);
    public GameProgram GetLocalProgram(string programName)=>
        GetLocalFile(programName) as GameProgram ?? throw new Exception($"Program {programName} not found");
    
    void Update(){
        RunProcess();
    }
    private void Start(){
        GraphManager.AddNode(this);
    }
    private void Awake()
    {
        files = GetComponentsInChildren<GameFile>().ToList();
        var guest = new User() { Username = "Guest", Role = Permission.Guest, PlayerHasAccess = true };
        _users.Add(guest);
        if(_nodeName == "")
            _nodeName = name;
    }
}
[System.Serializable]
public class User {
    public string Username;
    public Permission Role;
    public string Password;
    public string Email;
    public bool PlayerHasAccess;
    public string CachedPassword = "_"; //This is so Password and Cched Password don't match by default
}

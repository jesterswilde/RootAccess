#pragma warning disable 0649
using Sirenix.OdinInspector;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField]
    string nodeName;
    public string Name => nodeName;
    [SerializeField, PropertyTooltip("The message to display when a user logs in. Use $username to display the username. Leaving it blank will use default")]
    string _loginMessage = "Welcome back $username";
    public string LoginMessage => _loginMessage == "" ? "Welcome back $username" : _loginMessage;
    public int LoginAttempts {get; set;}
    [SerializeField]
    string hardware;
    public string Hardware => hardware;
    [SerializeField]
    string software;
    public string Software => software;
    [SerializeField, ReadOnly]
    User _currentUser;
    public User CurrentUser {
        get {
            _currentUser ??= _users.First(u => u.Username == "Guest");
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
    [SerializeField, ReadOnly]
    List<GameProcess> processes;
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
    public List<GameProcess> Processes => processes;
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
    public GameProcess StartProcess(string programName, GameFile target, int finishedAt)
    {
        var process = processes.Find(p => p.ProgramPath == programName && p.Target == target);
        if (process != null)
            return process;
        process = new GameProcess() { node = this, WorkRequired = finishedAt, ProgramPath = programName, Target = target, WorkDone = 0, IsIdle = false };
        processes.Add(process);
        return process;
    }
    public void EndProcess(GameProcess process)
    {
        processes.Remove(process);
    }
    public void AddFile(GameFile file)
    {
        files.Add(file);
        file.transform.SetParent(transform);
    }
    public List<GameFile> Files => files;
    private void Awake()
    {
        files = GetComponentsInChildren<GameFile>().ToList();
        var guest = new User() { Username = "Guest", Role = Permission.Guest, PlayerHasAccess = true };
        _users.Add(guest);
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

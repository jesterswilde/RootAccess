#pragma warning disable 0649
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Terminal : MonoBehaviour
{
    public static Terminal T { get; private set; }
    public event Action<string> OnStdOut;
    public event Action<GameProcess> OnStartProcess;
    public event Action<GameProcess> OnEndProcess;
    public event Action<GameProcess> OnTickProcess;
    [SerializeField]
    ControlPanel powerBrick;
    public static ControlPanel PowerBrick => T.powerBrick;
    [SerializeField]
    string _username;
    [SerializeField]
    string _terminalName = "HOME";
    public static string Username => T._username;

    [SerializeField]
    List<GameFile> localFiles;
    public List<GameFile> LocalFiles => localFiles;
    [SerializeField]
    Node _node;
    public Node Node { get => _node; set {
            _node = value;
            OnNodeChange?.Invoke(_node);
        } }
        public string NodeName => _node == null ? _terminalName : _node.name;
        public string CurrentUser => _node == null ? _username : _node.CurrentUser.Username;
        public string Path => $"{CurrentUser}@{NodeName}>";


    [SerializeField, ReadOnly]
    GameProcess currentProcess;

    public GameProcess CurrentProcess { get => currentProcess; set => currentProcess = value; }
    public bool IsBusy => !currentProcess.IsIdle;
    public event Action<Node> OnNodeChange;
    public List<GameProgram> Programs => localFiles.OfType<GameProgram>().ToList();
    public List<Node> KnownNodes { get {
            if (_node == null)
                return new List<Node>();
            return GraphManager.GetConnections(_node).Where(con => con.IsFound).Select(con => con.GetOther(_node)).ToList();
        } }
    public List<GameFile> NodeFiles => _node == null ? new List<GameFile>() : _node.Files;
    [SerializeField]
    int power = 10;
    int Power => power;
    public void TryPrint(string text)
    {
        OnStdOut?.Invoke(text);
    }
    public void AcceptInput(string command)
    {
        if(currentProcess.RequiresUserInput){
            var program = GetProgram(currentProcess.ProgramPath);
            program.HandleUserInput(command, currentProcess, this);
        }
        else
            ExecuteCommand(command);
    }
    void ExecuteCommand(string command){
        OnStdOut.Invoke($"\n{Path} {command}");
        var words = command.Split(" ");
        var action = words[0];
        var arguments = words.Skip(1).ToList();

        var program = Programs.Find(p => p.FileName == action);
        if (program == null)
            HandleCommandResult(new CommandResult() { Text = $"\n{TColor.Error}Command \"{action}\" Not Found {TColor.Close}" });
        else if(program.RequiresIdle && !currentProcess.IsIdle)
            HandleCommandResult(new CommandResult() { Text = $"\n{TColor.Error} Terminal is currently busy. Run `pause` to pause program. You can resume at any time by re-running the same command. {TColor.Close}" });
        else 
            HandleCommandResult(program.Run(arguments, this));

    }
    public GameProgram GetProgram(string programName)=>
        GetFile(programName, "program") as GameProgram ?? throw new Exception($"Program {programName} not found");
    public GameFile GetFile(string path, string fileType = "file"){
        var isGlobal = path.Contains(":");
        GameFile file;
        if(isGlobal){ //We have an absolute file path in the form of nodeName:fileName
            var (nodeName, fileName, _) = path.Split(":");
            file = GetGlobalFile(fileName, nodeName: nodeName, fileType: fileType);
            if(file == null)
                throw new Exception($"{fileType.TitleCase()} {path} not found");
            return file;
        }

        //We look up the file in the local directory first then in the global directory
        file = GetLocalFile(path);
        if(file != null)
            return file;
        file = GetGlobalFile(path, fileType: fileType);
        if(file == null)
            throw new Exception($"{fileType.TitleCase()} {path} not found");
        return file;
    }
    GameFile GetGlobalFile(string filename, string nodeName = "", string fileType = "file")
    {
        //If no node name is provided, we assume the file is in the current node
        Node node;
        if(nodeName == "")
            node = _node;
        else
            node = GraphManager.GetNode(nodeName);
        if(node == null)
            return null;

        var file = node.Files.Find(f => f.MatchesName(filename));
        if(file == null || !file.IsFound)
            return null;
        if(!node.Role.HasPermission(file.permissionRequired))
            throw new Exception($"Permission denied for {filename}");
        return file;
    }
    GameFile GetLocalFile(string fileName)=> Programs.Find(p => p.MatchesName(fileName)) ?? localFiles.Find(f => f.MatchesName(fileName));
    internal void SetNode(Node node)
    {
        _node = node;
        OnNodeChange?.Invoke(node);
    }

    void CompleteProgramExecution(string programName, GameFile target)
    {
        var program = GetProgram(programName);
        var result = program.CompleteProcess(target, this);
        if (result != "")
            OnStdOut?.Invoke($"\n{result}");
    }

    internal static void AddServer(WorldServer worldServer)
    {
        if (T == null)
        {
            Debug.LogWarning("Not terminal in game, cannot increase it's power");
            return;
        }
        T.power += worldServer.Power;
    }

    void HandleCommandResult(CommandResult result)
    {
        TryPrintCommand(result);
        TryRunProcess(result);
    }
    void TryPrintCommand(CommandResult result)
    {
        if (result.Text == "")
            return;
        OnStdOut?.Invoke(result.Text);
    }
    void TryRunProcess(CommandResult result)
    {
        if (result.Process == null || result.Process.IsIdle)
            return;
        currentProcess = result.Process;
        OnStartProcess?.Invoke(currentProcess);
    }
    public void AddFile(GameFile file)
    {
        file.transform.SetParent(transform);
        localFiles.Add(file);
        localFiles.Sort((a, b) => a.FileName.CompareTo(b.FileName));
    }
    void RunProcess()
    {
        if (currentProcess.IsIdle || currentProcess.RequiresUserInput)
            return;
        currentProcess.WorkDone += Power * Time.deltaTime;

        var program = GetProgram(currentProcess.ProgramPath);
        var result = program.TickProcess(currentProcess, this);
        if (result != "")
        {
            OnStdOut?.Invoke(result);
        }
        OnTickProcess?.Invoke(currentProcess);

        if(currentProcess.IsComplete)
        {
            OnEndProcess?.Invoke(currentProcess);
            CompleteProgramExecution(currentProcess.ProgramPath, currentProcess.Target);
            currentProcess.node.EndProcess(currentProcess);
            currentProcess = new GameProcess() { IsIdle = true};
        }
    }
    private void Update()
    {
        RunProcess();
    }
    private void Start()
    {
        var files = GetComponentsInChildren<GameFile>().ToList();
        LocalFiles.AddRange(files);
        currentProcess = new GameProcess() { IsIdle = true };
    }
    private void Awake()
    {
        T = this;
    }
}

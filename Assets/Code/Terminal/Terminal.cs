#pragma warning disable 0649
using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Terminal : MonoBehaviour
{
    public static Terminal T { get; private set; }
    public event Action<string> OnStdOut;
    public event Action OnClearInput;
    [SerializeField]
    ControlPanel powerBrick;
    
    public static ControlPanel PowerBrick => T.powerBrick;
    [SerializeField]
    ViewMonitor monitor;
    public ViewMonitor Monitor => monitor;
    [SerializeField]
    string _username;
    [SerializeField]
    string _terminalName = "HOME";
    public static string Username => T._username;

    public List<GameFile> LocalFiles => _fs.Files;
    [SerializeField]
    Node _fs;

    public Node FS => _fs;
    [SerializeField]
    Node _node;
    public Node Node { get => _node; set {
            _node = value;
            OnNodeChange?.Invoke(_node);
        } }
    public string NodeName => _node == null ? _terminalName : _node.Name;
    public string CurrentUser => _node == null ? _username : _node.CurrentUser.Username;
    public string Path => $"{CurrentUser}@{NodeName}>";


    public event Action<Node> OnNodeChange;
    public List<GameProgram> Programs => LocalFiles.OfType<GameProgram>().ToList();
    public List<Node> KnownNodes { get {
            if (_node == null)
                return new List<Node>();
            return GraphManager.GetConnections(_node).Where(con => con.IsFound).Select(con => con.GetOther(_node)).ToList();
        } }
    public List<GameFile> NodeFiles => _node == null ? new List<GameFile>() : _node.Files;
    public void TryPrint(string text)
    {
        OnStdOut?.Invoke(text);
    }
    public void ClearInput(){
        OnClearInput?.Invoke();
    }
    public void AcceptInput(string command)
    {
        if(_fs.CurrentProcess.RequiresUserInput){
            var program = GetProgram(_fs.CurrentProcess.ProgramPath);
            program.HandleUserInput(command, _fs.CurrentProcess);
        }
        else
            ExecuteCommand(command);
    }
    void ExecuteCommand(string command){
        OnStdOut.Invoke($"{Path} {command}");
        var words = command.Split(" ");
        var action = words[0];
        var arguments = words.Skip(1).ToList();

        var program = Programs.Find(p => p.FileName == action);
        if (program == null)
            HandleCommandResult(new CommandResult() { Text = $"{TColor.Error}Command \"{action}\" Not Found {TColor.Close}" });
        else if(program.RequiresIdle && !_fs.CurrentProcess.IsIdle)
            HandleCommandResult(new CommandResult() { Text = $"{TColor.Error} Terminal is currently busy. Run `pause` to pause program. You can resume at any time by re-running the same command. {TColor.Close}" });
        else {
            try{
                HandleCommandResult(program.Run(arguments, this));
            }catch(Exception e){
                if(e is TerminalError)
                    HandleCommandResult(new CommandResult() { Text = $"{TColor.Error} {e.Message} {TColor.Close}" });
                else
                    throw e;
            }
        }

    }
    public GameFile GetFile(string path){
        var isGlobal = path.Contains(":");
        if(isGlobal){
            var (nodeName, fileName, _) = path.Split(":");
            return Node.GetGlobalFile(path);
        }
        return _fs.GetLocalFile(path, allowNull: true) ??
            _node?.GetLocalFile(path);
    }
    public GameProgram GetProgram(string programName)=>
        _fs.GetLocalProgram(programName) ?? _node?.GetLocalProgram(programName);
    internal void SetNode(Node node)
    {
        _node = node;
        OnNodeChange?.Invoke(node);
    }


    internal static void AddServer(WorldServer worldServer)
    {
        throw new NotImplementedException();
    }

    void HandleCommandResult(CommandResult result)
    {
        TryPrintCommand(result);
        if (result.Process == null)
            return;
        result.Process.Node.StartProcess(result.Process);
    }
    void TryPrintCommand(CommandResult result)
    {
        if (result.Text == "")
            return;
        OnStdOut?.Invoke(result.Text);
    }
    
    void Start(){
        if(_node == null){
            _node = GraphManager.StartingNode;
        }
    }
    private void Awake()
    {
        T = this;
        if(_fs == null)
            throw new Exception("No file system found");
    }
}

using Sirenix.OdinInspector;
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
    List<GameFile> localFiles;
    public List<GameFile> LocalFiles => localFiles;
    [SerializeField]
    Node node;
    public Node Node { get => node; set {
            node = value;
            OnNodeChange?.Invoke(node);
        } }


    [SerializeField, ReadOnly]
    GameProcess currentProcess;

    public GameProcess CurrentProcess { get => currentProcess; set => currentProcess = value; }
    public bool IsBusy => !currentProcess.IsIdle;
    public event Action<Node> OnNodeChange;
    public List<GameProgram> Programs => localFiles.OfType<GameProgram>().ToList();
    [SerializeField]
    int power = 10;
    int Power => power;
    public void ExecuteCommand(string command)
    {
        var words = command.Split(" ");
        var action = words[0];
        var arguments = words.Skip(1).ToList();

        var program = Programs.Find(p => p.FileName == action);
        if (program == null)
            HandleCommandResult(new CommandResult() { Text = $"{TColor.Error}Command \"{action}\" Not Found {TColor.Close}" });
        else if(program.RequiresIdle && !currentProcess.IsIdle)
            HandleCommandResult(new CommandResult() { Text = $"{TColor.Error} Terminal is currently busy. Run `pause` to pause program. You can resume at any time by re-running the same command. {TColor.Close}" });
        else 
            HandleCommandResult(program.Run(arguments, this));
    }
    GameProgram GetLocalProgram(string programName)=>Programs.Find(p => p.FileName == programName);
    internal void SetNode(Node _node)
    {
        node = _node;
        OnNodeChange?.Invoke(_node);
    }

    void CompleteProgramExecution(string programName, GameFile target)
    {
        var program = GetLocalProgram(programName);
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
        if (currentProcess.IsIdle)
            return;
        currentProcess.WorkDone += Power * Time.deltaTime;

        var program = GetLocalProgram(currentProcess.Program);
        var result = program.TickProcess(currentProcess, this);
        if (result != "")
        {
            OnStdOut?.Invoke(result);
        }
        OnTickProcess?.Invoke(currentProcess);

        if(currentProcess.WorkDone > currentProcess.FinishedAt)
        {
            OnEndProcess?.Invoke(currentProcess);
            CompleteProgramExecution(currentProcess.Program, currentProcess.Target);
            currentProcess.node.EndProcess(currentProcess);
            currentProcess = new GameProcess() { IsIdle = true};
        }
    }
    private void Update()
    {
        RunProcess();
    }
    internal static void ViewTerminal()
    {
        throw new NotImplementedException();
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

[Serializable]
public class GameProcess
{
    public bool IsIdle = true;
    public string Program;
    public Node node;
    public GameFile Target;
    public int FinishedAt;
    public float WorkDone;
    public static GameProcess NullProcess() => new GameProcess() { IsIdle = true };
}

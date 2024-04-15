using System.Collections.Generic;
using Unity.VisualScripting;

public class PRG_SCP : GameProgram
{
    public override string CompleteProcess(GameProcess baseProcess)
    {
        var process = baseProcess as SCPProcess;
        var file = Node.GetGlobalFile(process.FilePath);
        process.Destination.AddFile(Node.GetGlobalFile(process.FilePath));
        return $"{TColor.Access} Copied {file.FileName} to {baseProcess.Node.Name} {TColor.Close}";
    }
    
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if(arguments.Count == 0)
            throw new TerminalError("Must include a target file");
        var file = term.GetFile(arguments[0]);
       
        if(term.Node == null)
            throw new TerminalError("Only works in nodes");
        if (!file.CanBeCopied) 
            throw new TerminalError("File is not copyable");

        bool isLocal = term.FS.IsLocal(file);
        SCPProcess process = new(){
            ProgramPath = GetPath(),
            FilePath = file.GetPath(),
            WorkRequired = file.FileSize,
            DaysRequired = file.FileSize / 1000,
            IsIdle = false,
            Node = isLocal ? term.FS : term.Node,
            Destination = isLocal ? term.Node : term.FS,
        };
        return new CommandResult()
        {
            Text = $"Starting to copy {file.FileName}",
            Process = process,
        };
    }
    class SCPProcess : GameProcess
    {
        public string FilePath;
        public Node Destination;
    }
}

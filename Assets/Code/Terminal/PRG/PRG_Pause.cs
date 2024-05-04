using System.Collections.Generic;

public class PRG_Pause : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if (term.FS.CurrentProcess.IsIdle)
            throw new TerminalError("No process currently running to pause.");
        var oldProcess = term.FS.CurrentProcess;
        term.FS.CurrentProcess = GameProcess.NullProcess();
            return new CommandResult() { Text = $"Ended process running {oldProcess.ProgramPath}" };
    }
}

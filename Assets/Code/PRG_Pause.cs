using System.Collections.Generic;

public class PRG_Pause : GameProgram
{
    public override bool CanBeCopied => true;

    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if (term.CurrentProcess.IsIdle)
            return new CommandResult() { Text = $"{TColor.Error}No process currently running to pause.{TColor.Close}" };
        var oldProcess = term.CurrentProcess;
        term.CurrentProcess = GameProcess.NullProcess();
            return new CommandResult() { Text = $"Ended process running {oldProcess.Program}" };
    }
}

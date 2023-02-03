using System.Collections.Generic;
using System.Linq;

public class PRG_Prg : GameProgram
{
    public override bool CanBeCopied => true;

    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        var words = term.Programs.Aggregate("", (a, b) => $"{a}   {b}");
        return new CommandResult() { Text = words };
    }
}


using System.Collections.Generic;
using System.Linq;

public class PRG_Ripper : GameProgram
{
    bool hasDictionary = false;
    bool hasRainbow = false;
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if (arguments.Count < 1) {
            throw new TerminalError("Usage: rip <passwordFile>");
        }

        var programName = arguments[0];
        var file = term.GetFile(arguments[0]);
        if (file == null) {
            throw new TerminalError($"File '{arguments[0]}' not found" );
        }

        return new CommandResult() { Text = $"Ripping '{programName}'" };
    }
}
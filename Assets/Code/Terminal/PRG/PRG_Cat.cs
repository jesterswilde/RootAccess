using System.Collections.Generic;

public class PRG_Cat : GameProgram
{

    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if (arguments.Count == 0)
            throw new TerminalError("Must supply a file to read");
        var file = term.GetFile(arguments[0]);
        if(file == null)
            throw new TerminalError("File not found");
        if (file.Text != "")
            return new CommandResult() { Text = file.Text };
        else
            throw new TerminalError("Cannot print file, consider using man or help");
    }
}

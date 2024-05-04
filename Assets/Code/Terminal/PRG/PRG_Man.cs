using System.Collections.Generic;

public class PRG_Man : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if (arguments.Count == 0)
            return new CommandResult() { Text = "man (help): this program is used on other programs to describe their functionality. \n Usage: 'man <filename>' \n Lost? Try running 'tut' to get an overview of the terminal (You're on the terminal right now." };
        var file = term.GetFile(arguments[0]);
        if(file == null)
            throw new TerminalError("File not found");
        if (file.GetMan() != "")
            return new CommandResult() { Text = file.GetMan() };
        else
            throw new TerminalError("No Man page exists for this file");
    }
}

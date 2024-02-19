using System.Collections.Generic;

public class PRG_Cat : GameProgram
{

    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if (arguments.Count == 0)
            return new CommandResult() { Text = $"{TColor.Error} Must supply a file to read{TColor.Close}" };
        var file = term.GetFile(arguments[0]);
        if(file == null)
            return new CommandResult() { Text = "File Not Found" };
        if (file.Text != "")
            return new CommandResult() { Text = file.Text };
        else
            return new CommandResult() { Text = $"{TColor.Error} Cannot print file, consider using man or help {TColor.Close}" };
    }
}

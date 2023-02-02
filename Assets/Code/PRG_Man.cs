using System.Collections.Generic;

public class PRG_Man : GameProgram
{
    public override bool CanBeCopied => true;

    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if (arguments.Count == 0)
            return new CommandResult() { Text = "man (help): this program is used on other programs to describe their functionality. \n Usage: man <filename> \n consider using inv to check local files or ls to check files on the node you are currently on." };
        var file = ResolvePath(arguments[0], term);
        if(file == null)
            return new CommandResult() { Text = "Program not found" };
        if (file.Man != "")
            return new CommandResult() { Text = file.Man };
        else
            return new CommandResult() { Text = $"{TColor.Error} No man page exists for this type of page. Consider creating one at https://gamepages.com/man.git {TColor.Close}" };
    }
}

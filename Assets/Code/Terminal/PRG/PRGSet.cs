using System.Collections.Generic;
using System.Linq;

public class PRGSet : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        var (filePath, channel, _) = arguments[0].Split("/");
        var exec = GetNode().GetFile(filePath) 
            ?? throw new System.Exception("File not found");
        if (exec is not ExecutorFile)
            throw new System.Exception("File is not an executor file");
        var command = string.Join("", arguments.Skip(1));
        (exec as ExecutorFile).SetCommand(channel, string.Join("", command));
        return new CommandResult(){Text = $"Run command: {command} on channel {(channel == "" ? "default" : channel)}"};
    }
}
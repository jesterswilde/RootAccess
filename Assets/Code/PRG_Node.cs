using System.Collections.Generic;

public class PRG_Node : GameProgram
{
    public override bool CanBeCopied => true;

    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        string result = $"Node: {term.Node.Name}\nCurrent Role: {term.Node.Role.Color()}{term.Node.Role}{TColor.Close}\nHardware: {term.Node.Hardware}\nSoftware: {term.Node.Software}";
        return new CommandResult() { Text = result };
    }
}

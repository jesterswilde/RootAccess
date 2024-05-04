using System.Collections.Generic;
using System.Linq;

public class PRG_Inventory : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        string result = "Local Files: \n";
        result += term.LocalFiles.Aggregate("", (a, f) => $"{a}    {f.FileName}");
        return new CommandResult() { Text = result };
    }
}

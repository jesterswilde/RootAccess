using System.Collections.Generic;
using System.Linq;

public class PRG_Ls : GameProgram
{
    public override bool CanBeCopied => true;

    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if (term.Node == null)
            return new CommandResult() { Text = $"{TColor.Error} LS only works inside of nodes. Try inv to view your local files and programs {TColor.Close}" };
        string files = $"Discoverd files on {term.Node.Name}\n";
        files += term.Node.Files
            .Where(f => f.IsFound)
            .Aggregate("", (words, f) => {
            var col = term.Node.Role.AccessColor(f.permissionRequired);
            return $"{words}    {col} {f.FileName} {TColor.Close}";
         });
        return new CommandResult() { Text = files };
    }
}

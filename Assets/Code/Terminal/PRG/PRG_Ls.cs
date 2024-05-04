using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

public class PRG_Ls : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if (term.Node == null)
            throw new TerminalError("LS only works inside of nodes. Try inv to view your local files and programs");
        var nodeFiles = term.Node.Files.Where(f => f.IsFound);
        if(nodeFiles.Count() == 0)
            return new CommandResult() { Text = "No files found" };
        string files = $"Discoverd files on {term.Node.Name}\n";
        files += nodeFiles.Aggregate("", (words, f) => {
            var col = term.Node.Role.AccessColor(f.permissionRequired);
            return $"{words}    {col} {f.FileName} {TColor.Close}";
         });
        return new CommandResult() { Text = files };
    }
}

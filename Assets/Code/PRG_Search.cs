using System.Collections.Generic;
using System.Linq;
using Sirenix.Utilities;

public class PRG_Search : GameProgram
{
    public override bool CanBeCopied => true;

    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        var files = term.Node.Files;
        
        var maxWork = files.Count == 0 ? 0 : files.Max(f => f.WorkToFind);
        return new CommandResult() {
            Text = $"Starting search of node: {term.Node.Name}",
            Process = new GameProcess() {
                FinishedAt = maxWork,
                node = term.Node,
                IsIdle = false,
                Program = "search",
            }
        };
    }
    public override string TickProcess(GameProcess process, Terminal term)
    {
        var newFiles = process.node.Files
            .Where(f => !f.IsFound && f.WorkToFind < process.WorkDone).ToList();
        if (newFiles.Count == 0)
            return "";
        newFiles.ForEach(f => f.IsFound = true);
        var result = newFiles.Aggregate("", (a, f) => $"{a}\nDiscovered new file: {f.FileName}");
        return result;
    }
    public override string CompleteProcess(GameFile target, Terminal term)
    {
        return "Search Complete.";
    }
}

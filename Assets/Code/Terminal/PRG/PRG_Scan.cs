using System.Collections.Generic;
using System.Linq;

public class PRG_Scan : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        var nodes = GraphManager.GetConnections(term.Node);
        UnityEngine.Debug.Log(nodes.Count());
        float maxWork = 0;
        if(nodes.Count() > 0)
            maxWork = nodes.Max(n => n.WorkToFind);
        return new CommandResult() {
            Text = $"Starting scan from node: {term.Node.Name}",
            Process = new GameProcess() {
                WorkRequired = (int)maxWork,
                Node = term.FS,
                IsIdle = false,
                ProgramPath = GetPath(),
            }
        };
    }
    public override string TickProcess(GameProcess process)
    {
        var newConnections = GraphManager.GetConnections(process.Node)
            .Where(c => !c.IsFound && c.WorkToFind < process.WorkDone).ToList();
        if (newConnections.Count == 0)
            return "";
        newConnections.ForEach(c => c.FoundConnection());
        return newConnections.Aggregate("", (a, f) => $"{a}\nDiscovered connection to node: {f.GetOther(process.Node).Name}");
    }
    public override string CompleteProcess(GameProcess process)
    {
        return "Search Complete.";
    }

}

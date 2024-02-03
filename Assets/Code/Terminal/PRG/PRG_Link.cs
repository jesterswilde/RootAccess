using System.Collections.Generic;
using System.Linq;

public class PRG_Link : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if (arguments.Count == 0)
            return GetAllConnections(term);
        return MoveToNode(arguments[0], term);
    }
    CommandResult GetAllConnections(Terminal term)
    {
        var result = GraphManager.GetConnections(term.Node)
            .Where(con => con.IsFound)
            .Aggregate("Known Connections:", (a, con) => $"{a}\n{con.HighestPermission.AccessColor(con.RequiredPerm)}{con.GetOther(term.Node).Name}{TColor.Close}");
        return new CommandResult() { Text = result };
    }
    CommandResult MoveToNode(string nodeName, Terminal term)
    {
        var target = GraphManager.GetConnections(term.Node).Find(c => c.GetOther(term.Node).Name == nodeName);
        if (target == null)
            return new CommandResult() { Text = $"{TColor.Error} No known connection to node {nodeName}{TColor.Close}" };
        if(!target.HighestPermission.HasPermission(target.RequiredPerm))
            return new CommandResult() { Text = $"{TColor.Error} You do not have sufficient privelages. Elevate your role{TColor.Close}" };
        term.Node = target.GetOther(term.Node);
        return new CommandResult() { Text = $"Linked into node {term.Node.Name}" };
    }
}
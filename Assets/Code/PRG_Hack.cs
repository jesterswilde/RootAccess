using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PRG_Hack : GameProgram
{
    public override bool CanBeCopied => true;
    [SerializeField]
    List<Hacks> hackType;
    [SerializeField]
    float speed;


    public override string CompleteProcess(GameFile target, Terminal term)
    {
        var curPermission = term.Node.Role;
        string result = $"{TColor.Error}Failure{TColor.Close} | This node was not vulnerable to Hack ${FileName} failed to raise permissions.";
        if(curPermission == Permission.Guest)
        {
            var success = hackType.Any(hack => term.Node.AdminVulnerabilities.Any(vuln => vuln == hack));
            if (success)
            {
                term.Node.ElevateRole(Permission.Admin);
                result = $"{TColor.Access}Success{TColor.Close} | Hack: ${FileName} successfully raised your role to {TColor.Admin}Admin{TColor.Close}";
            }
        }
        if(curPermission == Permission.Admin)
        {
            var success = hackType.Any(hack => term.Node.RootVulnerabilities.Any(vuln => vuln == hack));
            if (success)
            {
                term.Node.ElevateRole(Permission.Root);
                result = $"{TColor.Access}Success{TColor.Close} | Hack: ${FileName} successfully raised your role to {TColor.Root}Root{TColor.Close}";
            }
        }
        return result;
    }
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        GameProcess process = new GameProcess()
        {
            IsIdle = false,
            FinishedAt = (int)(term.Node.Security * speed),
            Program = FileName,
            node = term.Node,
        };
        return new CommandResult()
        {
            Text = $"Starting hack of node {term.Node.Name} with {FileName}",
            Process = process
        };
    }
}

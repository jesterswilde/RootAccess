#pragma warning disable 0649
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PRG_Hack : GameProgram
{
    [SerializeField]
    List<Hacks> hackType;
    [SerializeField]
    float speed = 1;


    public override string CompleteProcess(GameProcess process)
    {
        var curPermission = process.Node.Role;
        string result = $"{TColor.Error}Failure{TColor.Close} | This node was not vulnerable to Hack ${FileName} failed to raise permissions.";
        if(curPermission == Permission.Guest)
        {
            var success = hackType.Any(hack => process.Node.AdminVulnerabilities.Any(vuln => vuln == hack));
            if (success)
            {
                process.Node.ElevateRole(Permission.Admin);
                result = $"{TColor.Access}Success{TColor.Close} | Hack: {FileName} successfully raised your role to {TColor.Admin}Admin{TColor.Close}";
                curPermission = process.Node.Role;
            }
        }
        if(curPermission == Permission.Admin)
        {
            var success = hackType.Any(hack => process.Node.RootVulnerabilities.Any(vuln => vuln == hack));
            if (success)
            {
                process.Node.ElevateRole(Permission.Root);
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
            WorkRequired = (int)(term.Node.Security * speed),
            ProgramPath = FileName,
            Node = term.FS,
        };
        return new CommandResult()
        {
            Text = $"Starting hack of node {term.Node.Name} with {FileName}",
            Process = process
        };
    }
}

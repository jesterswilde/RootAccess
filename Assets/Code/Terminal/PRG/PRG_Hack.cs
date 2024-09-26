#pragma warning disable 0649
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PRG_Hack : GameProgram
{
    [SerializeField]
    List<Hacks> _hackTypes;
    [SerializeField]
    float speed = 1;


    public override string CompleteProcess(GameProcess process)
    {
        var curPermission = process.Node.Role;
        string result = $"{TColor.Error}Failure{TColor.Close} | This node was not vulnerable to Hack ${FileName} failed to raise permissions.";
        if(curPermission == Permission.Guest){
            bool didElevate = false;
            foreach(var hack in _hackTypes){
                foreach(var sVul in process.Node.AdminSoftwareVulns)
                    didElevate = didElevate || sVul == hack;
                foreach(var hVul in process.Node.AdminHardwareVulns)
                    didElevate = didElevate || hVul == hack;
            }
            if(didElevate){
                process.Node.ElevateRole(Permission.Admin);
                result = $"{TColor.Access}Success{TColor.Close} | Hack ${FileName} successfully raised permissions of ${process.Node.CurrentUser.Username} to ${TColor.Admin}Admin${TColor.Close}";
            }
        }if(curPermission == Permission.Admin){
            bool didElevate = false;
            foreach(var hack in _hackTypes){
                foreach(var sVul in process.Node.RootSoftwareVulns)
                    didElevate = didElevate || sVul == hack;
                foreach(var hVul in process.Node.RootHardwareVulns)
                    didElevate = didElevate || hVul == hack;
            }
            if(didElevate){
                process.Node.ElevateRole(Permission.Root);
                result = $"{TColor.Access}Success{TColor.Close} | Hack ${FileName} successfully raised permissions of ${process.Node.CurrentUser.Username} to ${TColor.Root}Root${TColor.Close}";
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

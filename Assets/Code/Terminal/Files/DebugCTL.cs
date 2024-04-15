#pragma warning disable 0649
using System;
using System.Collections.Generic;
using UnityEngine;

public class DebugCTL : ControlFile{
    public void Print(List<string> args){
        Debug.Log(string.Join(" ", args));
    }
    public override void ExecuteCommand(string command, List<string> args)
    {
        switch(command){
            case "print":
                Print(args);
                break;
            case "":
                Print(args);
                break;
            default:
                throw new Exception("Command not found");
        }
    }

    public override void AttachToControlPanel(ControlPanel powerbrick)
    {
        throw new NotImplementedException();
    }

    public override void DetachFromControlPanel(ControlPanel powerbrick)
    {
        throw new NotImplementedException();
    }
}
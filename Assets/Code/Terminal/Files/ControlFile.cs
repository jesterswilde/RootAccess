#pragma warning disable 0649
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public abstract class ControlFile : GameFile
{
    [SerializeField]
    string _objName;
    public string ObjName => _objName;
    [SerializeField]
    string _defaultChannel;
    public abstract void AttachToControlPanel(ControlPanel powerbrick);
    public abstract void DetachFromControlPanel(ControlPanel powerbrick);
    public virtual void ExecuteCommand(string command, List<string> args){ }
    float ToFloat (string[] args) => float.Parse(args[0]);
    Vector2 ToVector2 (string[] args){
        if(args.Length == 0)
            return Vector2.zero;
        if(args.Length == 1)
            return new Vector2(float.Parse(args[0]), float.Parse(args[0]));
        return new Vector2(float.Parse(args[0]), float.Parse(args[1]));
    }
    Vector3 ToVector3 (string[] args){
        if(args.Length == 0)
            return Vector3.zero;
        if(args.Length == 1)
            return new Vector3(float.Parse(args[0]), float.Parse(args[0]), float.Parse(args[0]));
        if(args.Length == 2)
            return new Vector3(float.Parse(args[0]), float.Parse(args[1]), 0);
        return new Vector3(float.Parse(args[0]), float.Parse(args[1]), float.Parse(args[2]));
    }
}

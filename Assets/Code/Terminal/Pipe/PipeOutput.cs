#pragma warning disable 0649
using System.Collections.Generic;
using UnityEngine;

public abstract class PipeOutput {
    [SerializeField]
    string outputName;
    public string OutputName => outputName;
    protected List<PipeInput> _connections = new List<PipeInput>();
    public virtual void Connect(PipeInput input){
        _connections.Add(input);
        input.CurrentOutput = this;
    }
    public virtual void Disconnect(PipeInput input){
        _connections.Remove(input);
    }
}

#pragma warning disable 0649
using System.Collections.Generic;
using UnityEngine;

public abstract class PipeOutput {
    [SerializeField]
    protected string outputName;
    public string OutputName => outputName;
    protected List<PipeInput> _connections = new List<PipeInput>();
    public virtual void Connect(PipeInput input){
        _connections.Add(input);
        input.CurrentOutput = this;
        input.OnOutputChanged += DisconnectInput;
    }
    public virtual void Disconnect(PipeInput input){
        if(_connections.Contains(input)){
            input.CurrentOutput = null;
        }
    }
    protected virtual void DisconnectInput(PipeInput input, PipeOutput newOutput){
        if(newOutput != this){
            _connections.Remove(input);
            input.OnOutputChanged -= DisconnectInput;
        }
    }
}

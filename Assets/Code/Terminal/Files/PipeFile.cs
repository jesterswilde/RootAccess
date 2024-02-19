#pragma warning disable 0649
using UnityEngine;

public class PipeFile : GameFile{
    [SerializeField]
    PipeInput _input;
    public PipeInput Input {get => _input; set{
        Disconnect();
        _input = value;
        Connect();
    }}
    [SerializeField]
    PipeOutput _output;
    public PipeOutput Output {get => _output; set{
        Disconnect();
        _output = value;
        Connect();
    }}

    public void Setup(PipeInput input, PipeOutput output){
        _input = input;
        _output = output;
        Connect();
    }
    public void Connect(){
        if (Input != null && Output != null){
            Output.Connect(Input);
        }
    }
    public void Disconnect(){
        if (Input != null && Output != null){
            Output.Disconnect(Input);
        }
    }
    protected override void Start(){
        base.Start();
        if (Input != null && Output != null){
            Connect();
        }
    }
}
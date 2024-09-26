#pragma warning disable 0649
using UnityEngine;

public class PipeDaemon : GameDaemon{
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

    public void Setup(PipeInput input, PipeOutput output, Node node){
        _input = input;
        _output = output;
        Connect();
        _input.OnOutputChanged += WatchInput;
    }
    public void Connect(){
        if (Input != null && Output != null){
            Output.Connect(Input);
        }
    }
    public void Disconnect(){
        Panic();
    }
    override public void RM(){
        Input.OnOutputChanged -= WatchInput;
        if (Input != null && Output != null){
            Output.Disconnect(Input);
        }
        base.RM();
    }
    public void WatchInput(PipeInput input, PipeOutput output){
        if(input == _input && output != _output){
            Panic();
        }
    }
    protected override void Start(){
        base.Start();
        if (Input != null && Output != null){
            Connect();
        }
    }
}
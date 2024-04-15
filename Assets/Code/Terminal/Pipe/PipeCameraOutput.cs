#pragma warning disable 0649
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PipeCameraOutput : PipeOutput{ 
    Camera _cam;
    public override void Connect(PipeInput input){
        base.Connect(input);
        if(_connections.Count == 1){
            _cam.enabled = true;
        }
        if (input is PipeVideoInput vid) {
            vid.SetTexture(_cam.targetTexture);
        }else{
            throw new System.Exception("Unsupported input type: " + input.GetType().Name);
        }
    }
    public override void Disconnect(PipeInput input)
    {
        base.Disconnect(input);
        if(_connections.Count == 0){
            _cam.enabled = false;
        }
    }
    public PipeCameraOutput(Camera cam){
        _cam = cam;
    }
    void Awake(){
        _cam.enabled = false;
    }
}
#pragma warning disable 0649
using Unity.VisualScripting;
using UnityEngine;

public class PipeImageOutput: PipeOutput{
    [SerializeField]
    Texture2D image;
    public Texture2D Image {
        get => image;
        set {
            image = value;
            foreach (PipeInput input in _connections)
            {
                input.CurrentOutput = this;
            }
        }
    }
    public override void Connect(PipeInput input){
        base.Connect(input);
        input.CurrentOutput = this;
        if(input is PipeVideoInput vid){
            vid.SetTexture(image);
        }
        else{
            throw new System.Exception("Unsupported input type: " + input.GetType().Name);
        }
    }
}

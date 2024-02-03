#pragma warning disable 0649
using UnityEngine;

public class PipeVideoInput : PipeInput{ 
    public Material Screen { get; set; }
    public void SetTexture(Texture texture)
    {
        Screen.mainTexture = texture;
    }
}
#pragma warning disable 0649
using Unity.VisualScripting;
using UnityEngine;

public class PipeVideoInput : PipeInput{ 
    public Renderer Screen { get; set; }
    public void SetTexture(Texture texture)
    {
        Screen.material.mainTexture = texture;
    }
}
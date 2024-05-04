#pragma warning disable 0649
using UnityEngine;

public class MonitorFile : InputFile {
    [SerializeField]
    Renderer screen;
    private void Awake()
    {
        Input = new PipeVideoInput {
            Screen = screen
        };
    }
}
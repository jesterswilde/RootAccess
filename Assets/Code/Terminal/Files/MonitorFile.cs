#pragma warning disable 0649
using UnityEngine;

public class MonitorFile : GameFile {
    [SerializeField]
    Material screen;
    public PipeVideoInput Input {get; private set;}

    private void Awake()
    {
        Input = new PipeVideoInput {
            Screen = screen
        };
    }
}
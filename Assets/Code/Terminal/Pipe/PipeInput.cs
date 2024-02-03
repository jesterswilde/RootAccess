#pragma warning disable 0649
using UnityEngine;

public class PipeInput{
    PipeOutput _currentOutput; 
    [SerializeField]
    string inputName;
    public string InputName;
    public PipeOutput CurrentOutput {
        get => _currentOutput;
        set {
            if (_currentOutput != null)
            {
                _currentOutput.Disconnect(this);
            }
            _currentOutput = value;
        }
    }
}

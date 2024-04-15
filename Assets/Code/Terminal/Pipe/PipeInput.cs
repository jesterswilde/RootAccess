#pragma warning disable 0649
using System;
using UnityEngine;

public class PipeInput{
    PipeOutput _currentOutput; 
    [SerializeField]
    string inputName;
    public string InputName => InputName;
    public event Action<PipeInput, PipeOutput> OnOutputChanged;
    public PipeOutput CurrentOutput {
        get => _currentOutput;
        set {
            _currentOutput = value;
            OnOutputChanged?.Invoke(this, value);
        }
    }
}

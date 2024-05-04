#pragma warning disable 0649
using System;
using UnityEngine;

public class MotionSensor : MonoBehaviour {
    [SerializeField]
    string _command;
    [SerializeField]
    float _shutoffTime;
    [SerializeField]
    LayerMask _mask;
    bool isOn; 
    float _timer;
    float _movementCheckTimer = 5f;
    float MovementCheckTimer => Mathf.Min(_shutoffTime, _movementCheckTimer);
    public string Command {get {return _command;} set {_command = value;}}
    Action<float> storedCommand; 
}

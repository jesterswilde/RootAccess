#pragma warning disable 0649
using UnityEngine;

public class ViewMonitor : MonoBehaviour{
    [SerializeField]
    MonitorFile _montior;
    public MonitorFile Monitor => _montior;
    [SerializeField]
    CameraFile _network;
    public CameraFile Network => _network;
    [SerializeField]
    OutputFile _forum;
    public OutputFile Forum => _forum;
}
#pragma warning disable 0649
using UnityEngine;

public class CameraFile : OutputFile
{
    [SerializeField]
    Camera _cam;
    public Camera Cam => _cam;
    private void Awake()
    {
        Output = new PipeCameraOutput(_cam);
    }
}
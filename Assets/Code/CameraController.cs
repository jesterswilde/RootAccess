using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController T { private set; get; }
    public static Camera Cam => T.cam;

    public static Vector3 Forward => T.transform.forward;
    public static Vector3 Right => T.transform.right;
    [SerializeField]
    Transform yControl;
    Camera cam;
    float xRot;
    float yRot;
    [SerializeField]
    float minViewDir;
    [SerializeField]
    float maxViewDir;
    Vector3 offset;

    PlayerSettings settings => GameManager.PlayerSettings;

    void Rotate()
    {
        xRot += Input.GetAxisRaw("Mouse X") * settings.CameraSensitivity;
        yRot += Input.GetAxisRaw("Mouse Y") * settings.CameraSensitivity;
        yRot = Mathf.Clamp(yRot, minViewDir, maxViewDir);

        transform.localEulerAngles = new Vector3(0, xRot, 0);
        yControl.localEulerAngles = new Vector3(-yRot, 0, 0);
    }
    private void Update()
    {
        if (ControlManager.Mode != ControlMode.World || ControlManager.LockView)
            return;
        Rotate();
        transform.position = Player.CamPos;
    }

    private void Awake()
    {
        cam = GetComponentInChildren<Camera>();
        T = this;
    }
    private void Start()
    {
        offset = Player.Position - transform.position;
    }
}

using System;
using UnityEngine;
using Sirenix.OdinInspector;

public class ControlManager : MonoBehaviour
{
    static ControlManager T;
    [SerializeField, ReadOnly]
    ControlMode currentMode;
    bool lockView = false;
    public static bool LockView { get => T.lockView; set => T.lockView = value; }
    public static ControlMode Mode => T.currentMode;
    public static event Action<ControlMode> OnModeChange;

    public static void EnterMode(ControlMode mode)
    {
        T.currentMode = mode;
        if(mode == ControlMode.Terminal){
            LockView = true;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if(mode == ControlMode.World){
            LockView = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if(mode == ControlMode.UI){
            LockView = true;
            Cursor.lockState = CursorLockMode.None;
        }
        OnModeChange?.Invoke(mode);
    }
    private void Update()
    {
        if (Mode == ControlMode.Terminal && Input.GetKeyDown(KeyCode.Escape))
            EnterMode(ControlMode.World);
        if (Mode == ControlMode.World && Input.GetKeyDown(KeyCode.T))
            EnterMode(ControlMode.Terminal);
    }

    private void Awake()
    {
        T = this;
    }
}
public enum ControlMode
{
    World,
    Terminal,
    UI
}


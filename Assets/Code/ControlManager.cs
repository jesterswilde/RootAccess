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
    public static event Action OnInteract;

    public static void EnterMode(ControlMode mode)
    {
        T.currentMode = mode;
        OnModeChange?.Invoke(mode);
    }
    private void Update()
    {
        if (Mode == ControlMode.Terminal && Input.GetKeyDown(KeyCode.Escape))
            EnterMode(ControlMode.World);
        if (Mode == ControlMode.World && Input.GetKeyDown(KeyCode.T))
            EnterMode(ControlMode.Terminal);
        if (Mode == ControlMode.World && Input.GetKeyDown(KeyCode.F))
            OnInteract?.Invoke();
    }

    private void Awake()
    {
        T = this;
    }
}
public enum ControlMode
{
    World,
    Terminal
}


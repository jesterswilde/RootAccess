using System;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
    static ControlManager T;
    ControlMode currentMode;
    public static ControlMode Mode => T.currentMode;
    public static event Action<ControlMode> OnModeChange;

    public static void EnterMode(ControlMode mode)
    {
        T.currentMode = mode;
        OnModeChange?.Invoke(mode);
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

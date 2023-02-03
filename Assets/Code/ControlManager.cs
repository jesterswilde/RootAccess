using System;
using UnityEngine;

public class ControlManager : MonoBehaviour
{
    static ControlManager T;
    [SerializeField]
    TerminalGUI termGUIPrefab;
    [SerializeField]
    TerminalGUI termGUI;
    ControlMode currentMode;
    public static ControlMode Mode => T.currentMode;
    public static event Action<ControlMode> OnModeChange;
    public static event Action OnInteract;

    public static void EnterMode(ControlMode mode)
    {
        if(T.currentMode == ControlMode.Terminal)
        {
            Destroy(T.termGUI.gameObject);
        }
        T.currentMode = mode;
        OnModeChange?.Invoke(mode);
        //if (mode == ControlMode.Terminal)
        //    T.ViewTerminal();        
    }
    void ViewTerminal()
    {
        termGUI = Instantiate(termGUIPrefab, GameManager.Canvas.transform) .Attach(Terminal.T);
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


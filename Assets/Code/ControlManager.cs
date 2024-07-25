using System;
using UnityEngine;
using Sirenix.OdinInspector;

public class ControlManager : MonoBehaviour
{
    static ControlManager T;
    MotionControler _moController;
    bool _lockView = false;
    public static bool LockView {
        get => T._lockView && T._moController.LockView;
        set => T._lockView = value;
    }
    public static MotionControler Mode => T._moController;
    [SerializeField, ReadOnly]
    public static event Action<ControlMode> OnModeChange;

    public static void EnterMode(MotionControler cont)
    {
        if(T._moController?.Mode == cont.Mode)
            return;
        if(!cont.CanTarget)
            Player.T.Target.ClearTarget();
        T._moController?.End?.Invoke();
        T._moController = cont;
        T._moController?.Start?.Invoke();
        OnModeChange?.Invoke(cont.Mode);
    }
    private void Update()
    {
        Mode?.Update?.Invoke(Time.deltaTime);
    }

    private void Awake()
    {
        T = this;
        EnterMode(MakeWorldController());
    }


    public static MotionControler MakeTerminalController()=>
        new(){
            Mode = ControlMode.Terminal,
            LockView = true,
            LockMode = CursorLockMode.None,
            Update = (delta) =>{
                if(Input.GetKeyDown(KeyCode.Escape)){
                    EnterMode(MakeWorldController());
                }
            }
        };

    public static MotionControler MakeWorldController()=>
        new(){
            Mode = ControlMode.World,
            CanTarget = true,
            UseWorldMovement = true,
            Start = ()=>{
                Debug.Log("World mode started");
            },
            Update = (delta) =>{
                if(Input.GetKeyDown(KeyCode.T))
                    EnterMode(MakeTerminalController());
                if(Input.GetKeyDown(KeyCode.Tab))
                    EnterMode(MakeUIController());
            }
        };

    public static MotionControler MakeUIController()=>
        new(){
            Mode = ControlMode.UI,
            LockView = true,
            LockMode = CursorLockMode.None,
            Update = (delta) =>{
                if(Input.GetKeyDown(KeyCode.Tab))
                    EnterMode(MakeWorldController());
                if(Input.GetKeyDown(KeyCode.Escape))
                    EnterMode(MakeWorldController());
            }
        };

}
public class MotionControler { 
    public ControlMode Mode;
    public bool LockView = false;
    public CursorLockMode LockMode = CursorLockMode.Locked;
    public Action<float> Update;
    public Action Start;
    public Action End;
    public bool CanTarget = false;
    public bool UseWorldMovement = false;
}
public enum ControlMode
{
    World,
    Terminal,
    UI,
    Ladder,
    Lerp

}


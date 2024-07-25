using Unity.VisualScripting;
using UnityEngine;

public class Ladder: MonoBehaviour, IInteractable { 
    [SerializeField]
    Detector _groundDetector;
    [SerializeField]
    Detector _topDetector;
    [SerializeField]
    Transform _ladderBottom;
    [SerializeField]
    Transform _ladderTop;
    [SerializeField]
    Transform _bottomExit;
    [SerializeField]
    Transform _topExit;
    float position = 0;
    float dist;

    public void GotInteracted() {
        Debug.Log("Ladder interacted");
        if(_groundDetector.IsBlocked){
            Debug.Log("Bottom enter");
            var lerpCont = LerpMotion.MakeLerpController(Player.Position, _ladderBottom.position, 0.5f, ()=>ControlManager.EnterMode(MakeController()));
            ControlManager.EnterMode(lerpCont);
        }else if(_topDetector.IsBlocked){
            Debug.Log("Top enter");
            var lerpCont = LerpMotion.MakeLerpController(Player.Position, _ladderTop.position, 0.5f, ()=>ControlManager.EnterMode(MakeController()));
            ControlManager.EnterMode(lerpCont);
        }
    }
    void CalculatePosition(){
        var botDist = Vector3.Distance(Player.Position, _ladderBottom.position);
        var topDist = Vector3.Distance(Player.Position, _ladderTop.position);
        if(botDist < topDist)
            position = 0;
        else
            position = 1;
        
    }
    void Move(float delta){
        if(Input.GetKey(KeyCode.W))
            position += delta * GameManager.PlayerSettings.ClimbSpeed / dist;
        if(Input.GetKey(KeyCode.S))
            position -= delta * GameManager.PlayerSettings.ClimbSpeed / dist;

        position = Mathf.Clamp01(position);
        Player.T.transform.position = Vector3.Lerp(_ladderBottom.position, _ladderTop.position, position);
    }
    void TryGetOff(){
        if(Input.GetKeyDown(KeyCode.F)){
            if(position == 0){
                Debug.Log("Bottom exit");
                var lerpCont = LerpMotion.MakeLerpController(Player.Position, _bottomExit.position, 0.5f, ()=>{
                    ControlManager.EnterMode(ControlManager.MakeWorldController());
                });
                ControlManager.EnterMode(lerpCont);
            }
            else if(position == 1){
                Debug.Log("Top exit");
                var lerpCont = LerpMotion.MakeLerpController(Player.Position, _topExit.position, 0.5f, ()=>{
                    ControlManager.EnterMode(ControlManager.MakeWorldController());
                });
                ControlManager.EnterMode(lerpCont);
            }
        }
    }

    MotionControler MakeController()=>
        new(){
            Mode = ControlMode.Ladder,
            CanTarget = false,
            UseWorldMovement = false,
            Start = ()=>{
                Debug.Log("Ladder mode started");
                CalculatePosition();
            },
            Update = (delta)=>{
                Move(delta);
                TryGetOff();
            }
        };


    void Awake(){
        dist = Vector3.Distance(_ladderBottom.position, _ladderTop.position);
    }
}
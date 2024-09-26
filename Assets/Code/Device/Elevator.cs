#pragma warning disable 0649
using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Elevator : SerializedMonoBehaviour { 
    ElevatorSystem _system;
    public ElevatorSystem Sys {get => _system; set => _system = value;}
    public enum ElevatorState{
        IDLE,
        UP,
        DOWN
    }
    public enum MotionState{
        MOVING,
        OPENING,
        CLOSING,
        OPEN,
        IDLE
    }
    [SerializeField, ReadOnly]
    public ElevatorState State {get; set;} = ElevatorState.IDLE;
    [SerializeField, ReadOnly]
    public MotionState MState {get; set;} = MotionState.IDLE;
    [SerializeField, PropertyTooltip("Start position is assumed to be closed position")]
    Transform _leftDoor;
    [SerializeField]
    Transform _leftDoorOpenTrans;
    Transform _leftDoorCloseTrans;
    [SerializeField, PropertyTooltip("Start position is assumed to be closed position")]
    Transform _rightDoor;
    [SerializeField]
    Transform _rightDoorOpenTrans;
    Transform _rightDoorCloseTrans;
    [SerializeField]
    List<string> _queue = new();
    [SerializeField]
    List<string> _otherDirectionQueue = new();
    float _changePercent = 0;


    public void QueueFloor(string floorName)=> QueueFloor(floorName, false);
    public void QueueFloor(string floorName, bool skipCheck){
        Debug.Log($"Queueing floor {floorName}");
        if(_queue.Contains(floorName) || _otherDirectionQueue.Contains(floorName) && !skipCheck)
            return;
        var diff = Sys.GetFloorElevation(floorName) - transform.position.y;
        if((diff < 0 && State == ElevatorState.UP) || (diff > 0 && State == ElevatorState.DOWN)){
            var index = InsertionIndexOfFloor(floorName, _otherDirectionQueue);
            _otherDirectionQueue.Insert(index, floorName);
        }else{
            var index = InsertionIndexOfFloor(floorName, _queue);
            _queue.Insert(index, floorName);
        }
        if(State == ElevatorState.IDLE){
            State = diff < 0 ? ElevatorState.DOWN : ElevatorState.UP;
            ToNextFloor();
        }
    }
    void Move(){
        if(_queue.Count() == 0){
            QueueEmpty();
            return;
        }
        var distMove = Sys.ElevatorSpeed * Time.deltaTime;
        var dir = State == ElevatorState.UP ? 1 : -1;
        var targetElevation = Sys.GetFloorElevation(_queue[0]);
        var distToTarget = Mathf.Abs(targetElevation - transform.position.y);
        if(distMove > distToTarget){
            transform.position = new Vector3(transform.position.x, targetElevation, transform.position.z);
            ArrivedAtFloor();
            return;
        }
        transform.position += Vector3.up * distMove * dir;
    }
    void ArrivedAtFloor(){
        _queue.RemoveAt(0);
        StartOpen();
    }
    void StartOpen(){
        MState = MotionState.OPENING;
        _changePercent = 0;
    }
    void Opening(){
        _changePercent += Time.deltaTime * Sys.OpenCloseSpeed;
        _changePercent = Mathf.Min(_changePercent, 1.0f);
        _leftDoor.transform.position = Vector3.Lerp(_leftDoorCloseTrans.position, _leftDoorOpenTrans.position, _changePercent);
        _rightDoor.transform.position = Vector3.Lerp(_rightDoorCloseTrans.position, _rightDoorOpenTrans.position, _changePercent);
        if(_changePercent >= 1.0f)
            StartHoldDoorsOpen();
    }
    void StartHoldDoorsOpen(){
        MState = MotionState.OPEN;
        _changePercent = 0;
    }
    void DoorsOpen(){
        _changePercent += Time.deltaTime / Sys.OpenDelay;
        if(_changePercent >= 1f)
            StartClosing();
    }
    void StartClosing(){
        MState = MotionState.CLOSING;
        _changePercent = 1f;
    }
    void Closing(){
        _changePercent -= Time.deltaTime * Sys.OpenCloseSpeed;
        _changePercent = Mathf.Min(_changePercent, 1.0f);
        _leftDoor.transform.position = Vector3.Lerp(_leftDoorCloseTrans.position, _leftDoorOpenTrans.position, _changePercent);
        _rightDoor.transform.position = Vector3.Lerp(_rightDoorCloseTrans.position, _rightDoorOpenTrans.position, _changePercent);
        if(_changePercent <= 0f)
            ToNextFloor();
    }
    void ToNextFloor(){
        if(_queue.Count() == 0)
            QueueEmpty();
        else
            MState = MotionState.MOVING;
    }
    void QueueEmpty(){
        State = ElevatorState.IDLE;
        MState = MotionState.IDLE;
        foreach(var floor in _otherDirectionQueue)
            TryQueueFloor(floor);
        _otherDirectionQueue.Clear();
        Sys.ElevatorNowIdle(this);
    }
    public bool TryQueueFloor(string floorName){
        if(TimeToFloor(floorName) < 0)
            return false;
        QueueFloor(floorName, true);
        return true;
    }
    public float TimeToFloor(string floorName){
        var targetPos = Sys.GetFloorElevation(floorName);
        var dist = targetPos - transform.position.y;
        if((State == ElevatorState.UP && dist < 0) || (State == ElevatorState.DOWN && dist > 0))
            return -1f;
        dist = Mathf.Abs(dist);
        var insertIndex = InsertionIndexOfFloor(floorName, _queue);
        return dist / Sys.ElevatorSpeed + insertIndex * Sys.FloorDelay;
    }
    public int InsertionIndexOfFloor(string _floorName, List<string> floors){
        var index = 0;
        var dist = Math.Abs(Sys.GetFloorElevation(_floorName) - transform.position.y);
        foreach(var _queueFloor in floors){
            var queueFloorDist = Math.Abs(Sys.GetFloorElevation(_queueFloor) - transform.position.y);
            if(queueFloorDist < dist)
                index++;
            else
                return index;
        }
        return index;
    }
    void SnapToNearestFloor(){
        var minDist = Mathf.Infinity;
        float y = 0f;
        foreach(var height in Sys.GetAllFloorsElevation()){
            var dist = Mathf.Abs(transform.position.y -  height);
            if(dist < minDist){
                minDist = dist;
                y = height;
            }
        }
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
    void Update(){
        if(MState == MotionState.MOVING)
            Move();
        else if(MState == MotionState.OPENING)
            Opening();
        else if(MState == MotionState.OPEN)
            DoorsOpen();
        else if(MState == MotionState.CLOSING)
            Closing();
    }
    void Awake(){
        _leftDoorCloseTrans = new GameObject().transform;
        _leftDoorCloseTrans.parent = transform;
        _leftDoorCloseTrans.position = _leftDoor.position;
        _rightDoorCloseTrans = new GameObject().transform;
        _rightDoorCloseTrans.parent = transform;
        _rightDoorCloseTrans.position = _rightDoor.position;
    }
    void Start(){
        SnapToNearestFloor();
    }
}
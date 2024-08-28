using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using UnityEngine;

public class ElevatorSystem : MonoBehaviour
{
    [SerializeField, ReadOnly]
    List<Elevator> _elevators = new();
    [SerializeField, BoxGroup("Settings")]
    float _openCloseSpeed = 1f;
    public float OpenCloseSpeed => _openCloseSpeed;
    [SerializeField, BoxGroup("Settings")]
    float _elevatorSpeed = 3f;
    public float ElevatorSpeed => _elevatorSpeed;
    [SerializeField, BoxGroup("Settings")]
    float _openDelay = 5f;
    public float OpenDelay => _openDelay;
    [SerializeField, BoxGroup("Settings")]
    float _floorDelay = 20f;
    public float FloorDelay => _floorDelay;
    public List<KeyValue> _floors;
    List<string> _floorQueue = new();

    public float GetFloorElevation(string name) => _floors.Find(f => f.Name == name).Pos.position.y;
    public void ElevatorNowIdle(Elevator el){
        _floorQueue = _floorQueue.Where(floor => !el.TryQueueFloor(floor)).ToList();
    }
    public List<float> GetAllFloorsElevation()=>
        _floors.Select(f => f.Pos.position.y).ToList();
    public void RequestElevatorUp(string floorName){
        RequestElevator(floorName, true);
    }
    public void RequestElevatorDown(string floorName){
        RequestElevator(floorName, false);
    }
    public void RequestElevator(string floorName, bool isUp){
        Debug.Log("Reuesting elevator");
        var dir = isUp ? Elevator.ElevatorState.UP : Elevator.ElevatorState.DOWN;
        var els = _elevators.Where(e => e.State == dir || e.State == Elevator.ElevatorState.IDLE);
        if(els.Count() == 0)
            _floorQueue.Add(floorName);
        var time = float.MaxValue;
        Elevator el = null;
        foreach(var curEl in els){
            var timeToFloor = curEl.TimeToFloor(floorName);
            if(timeToFloor < 0)
                continue;
            if(timeToFloor < time){
                time = timeToFloor;
                el = curEl;
            }
        }
        Debug.Log($"Elevator {el}");
        if(el == null){
            _floorQueue.Add(floorName);
        }else{
            el.QueueFloor(floorName);
        }
    }



    void Awake(){
        GetComponentsInChildren<Elevator>().ForEach(el => {
            el.Sys = this;
            _elevators.Add(el);
        });
    }
    [Serializable]
    public class KeyValue { 
        [HorizontalGroup("foo", LabelWidth = 40f)]
        public string Name;
        [HorizontalGroup("foo", LabelWidth = 30f)]
        public Transform Pos;

    }
}

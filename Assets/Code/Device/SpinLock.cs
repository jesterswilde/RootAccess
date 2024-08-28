#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class SpinLock : MonoBehaviour
{
    [SerializeField]
    bool _isHovered = false;
    [SerializeField]
    float _sensitivity;
    float _curVal = 0;
    public float Val => _curVal % _numbers;
    [SerializeField]
    Transform _rotTrans;
    [SerializeField]
    float _numbers = 60;
    [SerializeField]
    float _spinThreshold = 5f;
    [SerializeField]
    float _fudge = 3f;
    bool _isLocked = true;
    bool _spinningRight = true;
    [SerializeField]
    List<int> _code = new List<int>();
    [SerializeField]
    List<int> _entered = new List<int>();



    [SerializeField]
    UnityEvent onUnlock;

    void Reset(){
        _entered = new List<int>();
    }
    void NextStep(){
        var val = _curVal % _numbers;
        //if change direction
            //write down number
            //proceed to next step
            //if final step
                //unlock


        
    }
    void Turn()
    {
        if (!_isHovered)
            return;
        _curVal += Input.mouseScrollDelta.y * _sensitivity;
        _rotTrans.localEulerAngles = new Vector3(0, _curVal, 0);
    }


    private void OnMouseEnter()
    {
        Debug.Log("over dial");
        _isHovered = true;
    }
    private void OnMouseExit()
    {
        _isHovered = false;
    }
    private void Update()
    {
        Turn();
    }
}

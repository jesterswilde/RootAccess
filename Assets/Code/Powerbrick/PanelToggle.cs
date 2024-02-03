#pragma warning disable 0649
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class PanelToggle : MonoBehaviour
{
    bool isOn = false;
    [SerializeField]
    Transform rot;
    [SerializeField]
    float minThreshold;
    [SerializeField]
    Transform upPos;
    [SerializeField]
    Transform downPos;
    [SerializeField]
    int frames;
    Queue<float> spins = new Queue<float>();
    [SerializeField]
    FixedDisplay display;

    public event Action<bool> OnValueChange;
    public bool Value => isOn;

    private void OnMouseOver()
    {
        spins.Enqueue(Input.mouseScrollDelta.y);
        while (spins.Count > frames)
            spins.Dequeue();
        var speed = spins.Sum() * (isOn ? -1 : 1);
        if(speed > minThreshold)
        {
            isOn = !isOn;
            OnValueChange?.Invoke(isOn);
            if (isOn)
                rot.forward = upPos.forward;
            else
                rot.forward = downPos.forward;
        }
    }

    internal bool Setup(string displayText, Action<bool> onChange)
    {
        if (onChange != null)
            OnValueChange += onChange;
        display.Set(displayText);
        return isOn;
    }

    internal void Reset()
    {
        isOn = false;
        rot.forward = downPos.forward;
        foreach(var d in OnValueChange.GetInvocationList())
            OnValueChange -= (Action<bool>)d;
        display.Clear();
    }
}
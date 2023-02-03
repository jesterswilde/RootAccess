using System;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField]
    float minYRotation;
    [SerializeField]
    float maxYRotation;
    [SerializeField]
    float minValue;
    [SerializeField]
    float maxValue;
    [SerializeField]
    float curY;
    [SerializeField]
    float sensitivity;
    [SerializeField]
    Transform leverRoot;
    [SerializeField]
    FixedDisplay display;
    float value = 0;
    public event Action<float> OnValueChange;
    public float Value => value;
    internal void Move(float y)
    {
        curY += y * sensitivity;
        curY = Mathf.Clamp(curY, minYRotation, maxYRotation);
        leverRoot.transform.localEulerAngles = new Vector3(curY, 0, 0);
        value = curY.Map(minYRotation, minValue, maxYRotation, maxValue);
        OnValueChange?.Invoke(value);
    }

    internal float Setup(string displayText, Action<float> onChange = null)
    {
        if (onChange != null)
            OnValueChange += onChange;
        display.Set(displayText);
        return value;
    }

    internal void Reset()
    {
        curY = 0;
        leverRoot.transform.localEulerAngles = new Vector3(curY, 0, 0);
        value = curY.Map(minYRotation, minValue, maxYRotation, maxValue);
        foreach(var d in OnValueChange.GetInvocationList())
            OnValueChange -= (Action<float>)d;
        display.Clear();
    }
}

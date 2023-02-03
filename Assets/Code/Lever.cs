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
    float value = 0;
    public event Action<float> OnValueChange;
    internal void Move(float y)
    {
        curY += y * sensitivity;
        curY = Mathf.Clamp(curY, minYRotation, maxYRotation);
        leverRoot.transform.localEulerAngles = new Vector3(0, 0, curY);
        value = curY.Map(minYRotation, maxYRotation, minValue, maxValue);
        OnValueChange?.Invoke(value);
    }
}

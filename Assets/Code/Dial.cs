using System;
using UnityEngine;

public class Dial : MonoBehaviour
{
    [SerializeField]
    bool isHovered = false;
    [SerializeField]
    float sensitivity;
    [SerializeField]
    float minRot = -180;
    [SerializeField]
    float maxRot = 180;
    float curVal = 0;
    [SerializeField]
    Transform rotTrans;
    [SerializeField]
    float minVal = -1;
    [SerializeField]
    float maxVal = 1;
    [SerializeField]
    FixedDisplay display;

    internal float Setup(string text, Action<float> onChange = null)
    {
        if (onChange != null)
            OnValueChange += onChange;
        display.Set(text);
        return curVal;
    }

    float val = 0;
    public float Value => val;
    public event Action<float> OnValueChange;
    void Turn()
    {
        if (!isHovered)
            return;
        curVal += Input.mouseScrollDelta.y * sensitivity;
        curVal = Mathf.Clamp(curVal, minRot, maxRot);
        rotTrans.localEulerAngles = new Vector3(0, curVal, 0);
        val = curVal.Map(minRot, minVal, maxRot, maxVal);
    }

    internal void Reset()
    {
        curVal = 0;
        val = curVal.Map(minRot, minVal, maxRot, maxVal);
        rotTrans.localEulerAngles = new Vector3(0, curVal, 0);
        foreach(var d in OnValueChange.GetInvocationList())
            OnValueChange -= (Action<float>)d;
        display.Clear();
    }

    private void OnMouseEnter()
    {
        Debug.Log("over dial");
        isHovered = true;
    }
    private void OnMouseExit()
    {
        isHovered = false;
    }
    private void Update()
    {
        Turn();
    }
}

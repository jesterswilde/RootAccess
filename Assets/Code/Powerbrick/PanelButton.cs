#pragma warning disable 0649
using System;
using UnityEngine;
using UnityEngine.Events;

public class PanelButton : MonoBehaviour
{
    bool isInUse => state != States.Available;
    [SerializeField]
    bool isPressed = false;
    [SerializeField]
    Transform depressor;
    [SerializeField]
    Transform upPos;
    [SerializeField]
    Transform downPos;
    [SerializeField]
    float downSpeed;
    [SerializeField]
    float waitTime;
    [SerializeField]
    float upSpeed;
    [SerializeField]
    FixedDisplay display;
    States state = States.Available;
    float timer = 0;

    public event Action<float> OnPress;
    [SerializeField]
    UnityEvent unityOnPress;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0) && isPressed) {
            isPressed = false;
        }
        if (!isInUse && Input.GetMouseButtonDown(0)){
            OnPress?.Invoke(1f);
            unityOnPress?.Invoke();
            state = States.MovingDown;
            isPressed = true;
            timer = 0;
        }
    }

    internal void Setup(string displayText, Action<float> _onPress)
    {
        if (_onPress != null)
            OnPress += _onPress;
        display.Set(displayText);
    }

    private void OnMouseExit()
    {
        if (isPressed)
        {
            isPressed = false;
        }
    }

    internal void Reset()
    {
        foreach(var d in OnPress.GetInvocationList())
            OnPress -= (Action<float>)d;
        display.Clear();
    }

    private void Update()
    {
        if(state == States.MovingDown)
        {
            timer += Time.deltaTime;
            depressor.position = Vector3.Lerp(upPos.position, downPos.position, timer / downSpeed);
            if(timer >= downSpeed)
            {
                timer = 0;
                state = States.Pressed;
            }
        }
        if(state == States.Pressed && isPressed == false)
        {
            timer = 0;
            state = States.MovingUp;
        }
        if(state == States.MovingUp)
        {
            timer += Time.deltaTime;
            depressor.position = Vector3.Lerp(downPos.position, upPos.position, timer / upSpeed);
            if(timer >= upSpeed)
            {
                timer = 0;
                state = States.Available;
            }
        }
    }
    enum States
    {
        Available,
        MovingDown,
        Pressed,
        MovingUp
    }
}

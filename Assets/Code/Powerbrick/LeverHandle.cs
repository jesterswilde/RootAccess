using UnityEngine;

public class LeverHandle : MonoBehaviour
{
    Lever lever; 
    private void OnMouseDrag()
    {
        ControlManager.LockView = true;
        var y = Input.GetAxisRaw("Mouse Y");
        if(y != 0)
            lever.Move(y);
    }
    private void OnMouseUp()
    {
        ControlManager.LockView = false;
    }
    private void OnMouseExit()
    {
        ControlManager.LockView = false;
    }
    private void Awake()
    {
        lever = GetComponentInParent<Lever>();
    }
}

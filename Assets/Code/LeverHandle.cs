using UnityEngine;

public class LeverHandle : MonoBehaviour
{
    Lever lever; 
    private void OnMouseDrag()
    {
        var y = Input.GetAxisRaw("Mouse Y");
        if(y != 0)
            lever.Move(y);
    }
    private void Awake()
    {
        lever = GetComponentInParent<Lever>();
    }
}

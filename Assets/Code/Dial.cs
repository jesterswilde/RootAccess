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
    void Turn()
    {
        if (!isHovered)
            return;
        curVal += Input.mouseScrollDelta.y * sensitivity;
        curVal = Mathf.Clamp(curVal, minRot, maxRot);
        rotTrans.localEulerAngles = new Vector3(0, curVal, 0);
    }
    private void OnMouseEnter()
    {
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

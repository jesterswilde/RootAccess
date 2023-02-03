using UnityEngine;

public class Outliner : MonoBehaviour
{
    [SerializeField]
    Renderer outlineRend;
    private void OnMouseEnter()
    {
        outlineRend.enabled = true;
    }
    private void OnMouseExit()
    {
        outlineRend.enabled = false;
    }
    private void Awake()
    {
        outlineRend.enabled = false;
    }
}

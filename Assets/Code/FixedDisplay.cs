using UnityEngine;

public class FixedDisplay : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshPro text; 
    public void Set(string words)
    {
        text.text = words;
    }
    public void Clear()
    {
        text.text = "";
    }

}

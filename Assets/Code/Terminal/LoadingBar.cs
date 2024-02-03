#pragma warning disable 0649
using UnityEngine;

public class LoadingBar : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshProUGUI loading;
    [SerializeField]
    int dots = 100;
    public void UpdateBar(GameProcess process)
    {
        var percent = process.WorkDone / process.FinishedAt;
        var numBars = percent * dots;
        var result = "[";
        for(int i = 0; i < dots; i++)
        {
            if (i < numBars)
                result += "|";
            else
                result += ".";

        }
        result += "]";
        result += $" {(int)(percent * 100)}%";
        loading.text = result;

    }
}

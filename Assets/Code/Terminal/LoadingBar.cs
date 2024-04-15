#pragma warning disable 0649
using System.Text;
using UnityEngine;
using UnityEngine.UIElements;
public class LoadingBar : Label
{
    int numBlocks = 10;
    public LoadingBar(){
        AddToClassList("loading-bar");
        RegisterCallback<GeometryChangedEvent>(Setup);
    }
    void Setup(GeometryChangedEvent e){
        UnregisterCallback<GeometryChangedEvent>(Setup);
        var charWidth = MeasureTextSize("█", 0, MeasureMode.Undefined, 100, MeasureMode.Undefined);
        numBlocks = (int)(contentRect.width / charWidth.x);
        Debug.Log(numBlocks);
        UpdateProgress(0);
    }
    public void UpdateProgress(float progress){
        StringBuilder s = new ();
        var progressThreshold = 100f / numBlocks;
        for(var i = 0; i < numBlocks; i++){
            if(progress * 100 > i * progressThreshold)
                s.Append("█");
            else
                s.Append("░");
        }
        text = s.ToString();
    }
}

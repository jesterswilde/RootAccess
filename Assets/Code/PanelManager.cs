#pragma warning disable 0649
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PanelManager : MonoBehaviour{
    static PanelManager T;
    [SerializeField]
    int _defaultSize = 256;
    Camera _defaultCam;
    [SerializeField]
    List<PanelSettings> panels;
    Dictionary<int, (PanelSettings panel, RenderTexture rend)> _activePanels = new();
    Queue<(PanelSettings panel, RenderTexture rend)> _inactivePanels = new();
    Queue<PanelSettings> _unusedPanels = new();
    int index = 0;
    public static (int, PanelSettings settings) Link(UIDocument doc, Camera cam = null){
        if(cam == null)
            cam = T._defaultCam;
        PanelSettings settings = null;
        RenderTexture rend = null;
        if(T._inactivePanels.Count > 0)
            (settings, rend) = T._inactivePanels.Dequeue();
        else if(T._unusedPanels.Count > 0){
            settings = T._unusedPanels.Dequeue();
        }else
            throw new System.Exception("No more panels available");

        int index = T.index++;
        if(rend == null){
            rend = new RenderTexture(T._defaultSize, T._defaultSize, 24);
            rend.Create();
        }
        settings.targetTexture = rend;
        settings.SetScreenToPanelSpaceFunction(T._makeTranslationFunction(cam, settings));
        doc.panelSettings = settings;
        T._activePanels[index] = (settings, rend);
        return (index, settings);
    }
    public static void Unlink(int index){
        if(T._activePanels.ContainsKey(index)){
            var (panel, rend) = T._activePanels[index];
            panel.SetScreenToPanelSpaceFunction(null);
            T._activePanels.Remove(index);
            T._inactivePanels.Enqueue((panel, rend));
        }
        else 
            throw new System.Exception("Panel not found in active panels");
    }
    Func<Vector2, Vector2> _makeTranslationFunction(Camera targetCamera, PanelSettings panel){
        return (Vector2 screenPosition)=>{
            var invalidPosition = new Vector2(float.NaN, float.NaN);

            screenPosition.y = Screen.height - screenPosition.y;
            var cameraRay = targetCamera.ScreenPointToRay(screenPosition);

            RaycastHit hit;
            if (!Physics.Raycast(cameraRay, out hit))
            {
                return invalidPosition;
            }

            var targetTexture = panel.targetTexture;
            MeshRenderer rend = hit.transform.GetComponent<MeshRenderer>();

            if (rend == null || rend.sharedMaterial.mainTexture != targetTexture)
            {
                return invalidPosition;
            }

            Vector2 pixelUV = hit.textureCoord;

            //since y screen coordinates are usually inverted, we need to flip them
            pixelUV.y = 1 - pixelUV.y;

            pixelUV.x *= targetTexture.width;
            pixelUV.y *= targetTexture.height;

            return pixelUV;
        };
    }
    void Awake(){
        if(T != null){
            Destroy(gameObject);
            return;
        }else
            T = this;
        _defaultCam = Camera.main;
        foreach(var panel in panels){
            _unusedPanels.Enqueue(panel);
        }
    }
}
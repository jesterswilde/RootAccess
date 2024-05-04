#pragma warning disable 0649
using System;
using UnityEngine;
using UnityEngine.UIElements;

public class InteractiveScreen :MonoBehaviour{
    [SerializeField]
    Camera _cam; 
    [SerializeField]
    PanelSettings settings;
    Func <Vector2, Vector2> ScreenTranslation;

    void OnEnable(){
        if(settings == null)
            return;
        if(_cam == null)
            _cam = Camera.main;
        if(ScreenTranslation == null)
            ScreenTranslation = (pos)=> ScreenCoordinatesToRenderTexture(pos);
        settings.SetScreenToPanelSpaceFunction(ScreenTranslation);
    }
    void OnDisable(){
        if(settings == null)
            return;
        settings.SetScreenToPanelSpaceFunction(null);
    } 

    Vector2 ScreenCoordinatesToRenderTexture(Vector2 screenPosition){
        var invalidPosition = new Vector2(float.NaN, float.NaN);

        screenPosition.y = Screen.height - screenPosition.y;
        var cameraRay = _cam.ScreenPointToRay(screenPosition);

        RaycastHit hit;
        if (!Physics.Raycast(cameraRay, out hit))
            return invalidPosition;

        var targetTexture = settings.targetTexture;
        MeshRenderer rend = hit.transform.GetComponent<MeshRenderer>();

        if (rend == null || rend.sharedMaterial.mainTexture != targetTexture)
            return invalidPosition;

        Vector2 pixelUV = hit.textureCoord;

        //since y screen coordinates are usually inverted, we need to flip them
        pixelUV.y = 1 - pixelUV.y;

        pixelUV.x *= targetTexture.width;
        pixelUV.y *= targetTexture.height;

        return pixelUV;    
    }
}

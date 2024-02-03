#pragma warning disable 0649
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Sirenix.Utilities;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    Detector playerDetector;
    [SerializeField]
    float highlightSpeed = 0.5f;
    [SerializeField]
    Color highlightColor = Color.red;
    [SerializeField]
    float lerp = 0;
    [SerializeField]
    bool playerIsNear = false;

    List<Renderer> rends;
    List<Color> baseColors;
    Action GotInteractedWith;
    bool isDeactivated = false;

    void PlayerEnter()
    {
        if (isDeactivated)
            return;
        playerIsNear = true;
        ControlManager.OnInteract += GotInteractedWith;
    }
    void PlayerExit()
    {
        if (isDeactivated)
            return;
        playerIsNear = false;
        ControlManager.OnInteract -= GotInteractedWith;
    }
    internal void Deactivate()
    {
        isDeactivated = true;
        ControlManager.OnInteract -= GotInteractedWith;
    }

    private void Update()
    {
        if (isDeactivated)
        {
            if(lerp > 0)
            {
                lerp -= Time.deltaTime * (1 / highlightSpeed);
                lerp = MathF.Max(0, lerp);
                rends.ForEach((r, i) => r.material.color = Color.Lerp(baseColors[i], highlightColor, lerp));
            }
            return;
        }
        if(playerIsNear && lerp < 1)
        {
            lerp += Time.deltaTime * (1 / highlightSpeed);
            lerp = MathF.Min(1, lerp);
            rends.ForEach((r, i) => r.material.color = Color.Lerp(baseColors[i], highlightColor, lerp));
        }
        if(!playerIsNear && lerp > 0)
        {
            lerp -= Time.deltaTime * (1 / highlightSpeed);
            lerp = MathF.Max(0, lerp);
            rends.ForEach((r, i) => r.material.color = Color.Lerp(baseColors[i], highlightColor, lerp));
        }
    }

    private void Awake()
    {
        rends = GetComponentsInChildren<Renderer>().ToList();
        baseColors = rends.Select(r => r.material.color).ToList();
        var inter = GetComponents<Component>().First(c => c is IInteractable) as IInteractable;
        if (inter == null)
            throw new Exception($"Need to attach an IInteracbtable component to game object {name}");
        GotInteractedWith = inter.GotInteracted;
        playerDetector.OnBlocked += PlayerEnter;
        playerDetector.OnUnblocked += PlayerExit;
    }

}


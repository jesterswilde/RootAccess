﻿#pragma warning disable 0649
using UnityEngine;

[RequireComponent(typeof(Interactable))]
public class WorldProgram : MonoBehaviour, IInteractable
{
    [SerializeField]
    GameFile filePrefab;
    Interactable inter;
    public void GotInteracted()
    {
        if (Terminal.T != null)
            Terminal.T.FS.AddFile(Instantiate(filePrefab));
        else
            Debug.Log($"tried to add {filePrefab.FileName}");
        //inter.Deactivate();
        Destroy(gameObject);
    }
    private void Awake()
    {
        inter = GetComponent<Interactable>();
    }
}


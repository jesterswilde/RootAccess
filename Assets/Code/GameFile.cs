using System;
using UnityEngine;

public abstract class GameFile : MonoBehaviour
{
    [HideInInspector]
    public bool IsOwned = false;
    [SerializeField]
    bool isFound = false;
    public bool IsFound { get => isFound; set => isFound = value; }
    [SerializeField]
    protected string fileName;
    [SerializeField]
    public Permission permissionRequired;
    public Permission PermissionRequired => permissionRequired;
    [SerializeField]
    string text;
    public String Text => text;
    [SerializeField, TextArea]
    string man;
    [SerializeField]
    public string Man => man;
    [SerializeField]
    int workToFind;
    public int WorkToFind => workToFind;
    [SerializeField]
    int fileSize;
    public int FileSize => fileSize;
    public abstract bool CanBeCopied { get; }
    public string FileName => fileName;
    private void Start()
    {
        if (WorkToFind == 0)
            isFound = true;
    }
}

#pragma warning disable 0649
using System;
using UnityEngine;

public abstract class GameFile : MonoBehaviour
{
    [HideInInspector]
    public bool IsOwned = false;
    [SerializeField]
    bool _isFound = false;
    public bool IsFound { get => _isFound; set => _isFound = value; }
    [SerializeField]
    protected string _fileName;
    public string FileName { get => _fileName; set => _fileName = value; }
    public virtual bool MatchesName(string name) => FileName.ToLower() == name.ToLower();
    [SerializeField]
    public Permission permissionRequired;
    public Permission PermissionRequired => permissionRequired;
    [SerializeField]
    protected string _text;
    public String Text => _text;
    [SerializeField, TextArea]
    string _man;
    [SerializeField]
    public string Man => _man;
    [SerializeField]
    int workToFind;
    public int WorkToFind => workToFind;
    [SerializeField]
    int _fileSize;
    public int FileSize => _fileSize;
    [SerializeField]
    protected bool _canBeCopied = true;
    public bool CanBeCopied => _canBeCopied;
    public string GetPath(){
        var parentNode = GetComponentInParent<Node>();
        if(parentNode == null)
            return $"{FileName}";
        return $"{parentNode.Name}:{FileName}";
    }
    protected virtual void Start()
    {
        if (WorkToFind == 0)
            _isFound = true;
    }
}

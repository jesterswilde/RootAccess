#pragma warning disable 0649
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

public class GameTextFile : GameFile
{
    [SerializeField, FilePath(AbsolutePath = true, Extensions = "txt")]
    string filePath;

    protected override void Start()
    {
        base.Start();
        if(filePath != null && filePath != "" && System.IO.File.Exists(filePath))
            _text = System.IO.File.ReadAllText(filePath);
    }
}

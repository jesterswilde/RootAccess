#pragma warning disable 0649
using UnityEngine;
using UnityEngine.UIElements;

public class UIFile : OutputFile{
    [SerializeField]
    UIDocument _doc;
    void Awake(){
        Output = new PipeUIOutput(_doc);
    }
}
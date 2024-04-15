#pragma warning disable 0649
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;

[System.Serializable]
public class Journal {
    [SerializeField]
    List<string> _quests = new();
    public List<string> Quests => _quests;
}
[System.Serializable]
public class Quest {
    public string Name;
    public List<string> Objectives;
}
public class ObjectiveManager : MonoBehaviour { 
    public static ObjectiveManager T {get; private set;}

    

    void Awake(){
        if(T != null){
            Destroy(this);        
        }
        T = this;
    }
}
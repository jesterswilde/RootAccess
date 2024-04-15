#pragma warning disable 0649
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SceneManager : MonoBehaviour{
    static SceneManager T;
    private void Awake()
    {
        if(T == null)
            T = this;
        else
            Destroy(gameObject);
    }
}
public class DialogManager : MonoBehaviour{
    static DialogManager T;
    [SerializeField]
    UIDocument ui;
    public static void ShowDialogue(string text, List<DialogueOption> options){
        var dialogue = new DialogueUI(text, options);
        T.ui.enabled = true;
        T.ui.rootVisualElement.Add(dialogue);
    }
    private void Awake()
    {
        if(T == null)
            T = this;
        else
            Destroy(gameObject);
    }
}
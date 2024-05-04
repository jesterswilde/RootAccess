#pragma warning disable 0649
using UnityEngine;
using UnityEngine.UIElements;

public class TextSelector : MonoBehaviour { 
    [SerializeField]
    UIDocument document;
    void OnMouseDown(MouseDownEvent e){
    }
    void Start(){
        var els =  document.rootVisualElement.Query<Label>().ToList();
        foreach(var el in els){
            el.selection.isSelectable = true;
            el.selection.cursorIndex = 0;
            el.selection.selectIndex = 5;
            el.selection.selectionColor = Color.red;
            el.selection.SelectAll();
        }
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.A))
            document.rootVisualElement.Q<Label>().selection.SelectAll();
    }
}
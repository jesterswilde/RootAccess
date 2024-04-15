#pragma warning disable 0649
using System.Collections.Generic;
using UnityEngine.UIElements;

public class DialogueUI : VisualElement{
    public DialogueUI(string text, List<DialogueOption> options){
        var label = new Label(text);
        Add(label);
        var buttonContainer = new VisualElement();
        buttonContainer.AddToClassList("button-container");
        Add(buttonContainer);
        foreach(var option in options){
            var button = new Button();
            button.clicked += option.OnClick;
            button.text = option.Text;
            foreach(var c in option.Classes){
                button.AddToClassList(c);
            }
            buttonContainer.Add(button);
        }
    }
}

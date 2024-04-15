#pragma warning disable 0649
using UnityEngine.UIElements;

public class RadialMenuOptionUI: VisualElement{
    public RadialMenuOptionUI(RadialMenuOption option, float width){
        var icon = new Image {
            sprite = option.Icon
        };
        Add(icon);
        var label = new Label(option.Text);
        label.style.whiteSpace = WhiteSpace.Normal;
        Add(label);
        RegisterCallback<MouseDownEvent>(e => option.OnSelected());
        RegisterCallback<MouseEnterEvent>(e => Hover());
        RegisterCallback<MouseLeaveEvent>(e => Unhover());
        AddToClassList("radial-option");
        style.width = width;
        style.height = width;
        style.position = Position.Absolute;
    }
    void Hover(){
        AddToClassList("hover");
    }
    void Unhover(){
        RemoveFromClassList("hover");
    }
}

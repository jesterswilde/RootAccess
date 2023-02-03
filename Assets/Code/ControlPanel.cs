using System;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanel : MonoBehaviour
{
    [SerializeField]
    List<Dial> dials;
    [SerializeField]
    List<Lever> levers;
    [SerializeField]
    List<PanelToggle> toggles;
    [SerializeField]
    List<PanelButton> buttons;

    public float LinkToDial(int index, string displayText, Action<float> onChange)=>
        dials[index].Setup(displayText, onChange);
    public float LinkToLever(int index, string displayText, Action<float> _onChange)=>
        levers[index].Setup(displayText, _onChange);
    public bool LinkToToggle(int index, string displayText, Action<bool> _onChange)=>
        toggles[index].Setup(displayText, _onChange);
    public void LinkToButton(int index, string displayText, Action _onPress)=>
        buttons[index].Setup(displayText, _onPress);
    public void Reset()
    {
        dials.ForEach(d => d.Reset());
        levers.ForEach(l => l.Reset());
        toggles.ForEach(t => t.Reset());
        buttons.ForEach(b => b.Reset());
    }
}

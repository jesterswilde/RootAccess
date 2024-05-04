#pragma warning disable 0649
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanel : MonoBehaviour
{
    bool isBusy = false;
    public bool IsBusy => isBusy;
    [SerializeField]
    List<Dial> dials;
    [SerializeField]
    List<Lever> levers;
    [SerializeField]
    List<PanelToggle> toggles;
    [SerializeField]
    List<PanelButton> buttons;

    public float LinkToDial(int index, string displayText, Action<float> onChange){
        isBusy = true;
        return dials[index].Setup(displayText, onChange);
    }

    public float LinkToLever(int index, string displayText, Action<float> _onChange)
    {
        isBusy = true;
        return levers[index].Setup(displayText, _onChange);
    }
    public bool LinkToToggle(int index, string displayText, Action<float> _onChange)
    {
        isBusy = true;
        return toggles[index].Setup(displayText, _onChange);
    }
    public void LinkToButton(int index, string displayText, Action<float> _onPress)
    {
        isBusy = true;
        buttons[index].Setup(displayText, _onPress);
    }
    public void Reset()
    {
        isBusy = false;
        dials.ForEach(d => d.Reset());
        levers.ForEach(l => l.Reset());
        toggles.ForEach(t => t.Reset());
        buttons.ForEach(b => b.Reset());
    }
}

#pragma warning disable 0649
using System;
using UnityEngine;

public class RadialMenuOption { 
    public string Text;
    public Action Callback;
    public Action OnSelected;
    public Sprite Icon;
}
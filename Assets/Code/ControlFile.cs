using UnityEngine;
public abstract class ControlFile : GameFile
{
    [SerializeField]
    string objName;
    public string ObjName => objName;
    public abstract void AttachToControlPanel(ControlPanel powerbrick);
    public abstract void DetachFromControlPanel(ControlPanel powerbrick);
}

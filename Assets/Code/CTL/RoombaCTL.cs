#pragma warning disable 0649
using UnityEngine;

public class RoombaCTL : ControlFile
{
    [SerializeField]
    Roomba roomba;

    public override void AttachToControlPanel(ControlPanel powerbrick)
    {
        powerbrick.LinkToToggle(0, "ON", roomba.SetOn);
        powerbrick.LinkToToggle(1, "VCM", roomba.SetVaccum);
        powerbrick.LinkToLever(0, "SPD", roomba.SetSpeed);
        powerbrick.LinkToLever(1, "TURN", roomba.SetTurn);
    }

    public override void DetachFromControlPanel(ControlPanel powerbrick)
    {
    }
}

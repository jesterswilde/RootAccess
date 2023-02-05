using UnityEngine;

public class TankController : ControlFile
{
    [SerializeField]
    Tank tank;

    public override void AttachToControlPanel(ControlPanel powerbrick)
    {
        powerbrick.LinkToToggle(0, "ON", tank.TurnOn);
        powerbrick.LinkToLever(0, "SPD", tank.SetSpeed);
        powerbrick.LinkToLever(1, "TURN", tank.SetTurn);
        powerbrick.LinkToButton(0, "CANN", tank.Fire);
    }


    public override void DetachFromControlPanel(ControlPanel powerbrick)
    {
        tank.SetPlayerControlled(false);
    }
}


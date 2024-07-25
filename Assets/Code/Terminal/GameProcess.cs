#pragma warning disable 0649
using System;

[Serializable]
public class GameProcess
{
    public bool IsIdle = true;
    public bool isBlocking = false;
    public string ProgramPath;
    public Node Node;
    public float WorkRequired;
    public float WorkDone;
    public float TimePeriodsRequired;
    public float TimePeriodsPassed;
    public bool IsComplete => TimePeriodsPassed >= TimePeriodsRequired && WorkDone >= WorkRequired;
    public float Progress => TimePeriodsRequired > 0 ? TimePeriodsPassed / TimePeriodsRequired : WorkDone / WorkRequired;
    public bool RequiresUserInput = false;
    public bool HasLoadingBar = false;
    public static GameProcess NullProcess() => new GameProcess() { IsIdle = true };
}

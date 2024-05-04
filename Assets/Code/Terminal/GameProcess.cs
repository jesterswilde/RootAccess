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
    public float DaysRequired;
    public float DaysPassed;
    public bool IsComplete => DaysPassed >= DaysRequired && WorkDone >= WorkRequired;
    public float Progress => DaysRequired > 0 ? DaysPassed / DaysRequired : WorkDone / WorkRequired;
    public bool RequiresUserInput = false;
    public bool HasLoadingBar = false;
    public static GameProcess NullProcess() => new GameProcess() { IsIdle = true };
}

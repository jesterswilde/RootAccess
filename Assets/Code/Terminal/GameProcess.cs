#pragma warning disable 0649
using System;
using System.Security;
using Unity.VisualScripting;
using UnityEngine;

[Serializable]
public class GameProcess
{
    public bool IsIdle = true;
    public string ProgramPath;
    public Node node;
    public GameFile Target;
    public float WorkRequired;
    public float WorkDone;
    public float DaysRequired;
    public float DaysPassed;
    public bool IsComplete => DaysPassed >= DaysRequired && WorkDone >= WorkRequired;
    public float Progress => DaysRequired > 0 ? DaysPassed / DaysRequired : WorkDone / WorkRequired;
    public bool RequiresUserInput = false;
    public bool HasLoadingBar = true;
    public static GameProcess NullProcess() => new GameProcess() { IsIdle = true };
}

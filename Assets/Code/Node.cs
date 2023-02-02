using Sirenix.OdinInspector;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField]
    string nodeName;
    public string Name => nodeName;
    [SerializeField]
    Permission role = Permission.Guest;
    public Permission Role => role;

    [SerializeField, ReadOnly]
    List<GameFile> files;
    [SerializeField, ReadOnly]
    List<GameProcess> processes;
    [SerializeField, ReadOnly]
    List<Connection> connections;
    public List<GameProcess> Processes => processes;
    public void ElevateRole(Permission perm)
    {
        role = perm;
    }
    public GameProcess StartProcess(string programName, GameFile target, int finishedAt)
    {
        var process = processes.Find(p => p.Program == programName && p.Target == target);
        if (process != null)
            return process;
        process = new GameProcess() { node = this, FinishedAt = finishedAt, Program = programName, Target = target, WorkDone = 0, IsIdle = false };
        Debug.Log($"{process.Program} {process.IsIdle}");
        processes.Add(process);
        return process;
    }
    public void EndProcess(GameProcess process)
    {
        processes.Remove(process);
    }
    public List<GameFile> Files => files;
    private void Awake()
    {
        files = GetComponentsInChildren<GameFile>().ToList();
    }
}

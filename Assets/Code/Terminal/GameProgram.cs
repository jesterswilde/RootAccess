using System.Collections.Generic;
using System;
using UnityEngine;
using Sirenix.OdinInspector;

[Serializable]
public abstract class GameProgram : GameFile
{
    [SerializeField]
    protected bool requiresIdle = false;
    [SerializeField, PropertyTooltip("System Programs are commands that are built into every server, such as logging in or out. This is just about categorization")]
    protected bool isSystemProgram = false;
    public bool RequiresIdle => requiresIdle;
    [SerializeField]
    List<string> aliases;
    public abstract CommandResult Run(List<string> arguments, Terminal term);
    public virtual CommandResult RunFromPipe(string pipedData, List<string> arguments, Terminal term){
        arguments.Insert(0, pipedData);
        return Run(arguments, term);
    }
    public override bool MatchesName(string name)
    {
        name = name.ToLower();
        if(aliases != null)
            foreach (var alias in aliases)
                if (alias.ToLower() == name)
                    return true;
        return base.MatchesName(name);
    }
    public virtual string TickProcess(GameProcess process, Terminal term) => "";
    public virtual string CompleteProcess(GameFile target, Terminal term) => "Not overriden homie";
    public virtual void HandleUserInput(string input, GameProcess process, Terminal term){}
}

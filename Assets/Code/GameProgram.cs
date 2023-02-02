using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public abstract class GameProgram : GameFile
{
    [SerializeField]
    protected bool requiresIdle = false;
    public bool RequiresIdle => requiresIdle;
    public abstract CommandResult Run(List<string> arguments, Terminal term);
    public virtual string CompleteProcess(GameFile target, Terminal term) => "Not overriden homie";
    protected static GameFile ResolvePath(string path, Terminal term)
    {
        var resolvedPath = path.ToLower().Trim();
        var file = term.LocalFiles.Find(f => f.FileName.ToLower().Trim() == resolvedPath);
        if (file != null)
            return file;
        if(term.Node != null)
            file = term.Node.Files.Find(f => f.FileName.ToLower().Trim() == resolvedPath);
        return file;
    }
}

public class PRG_Pause : GameProgram
{
    public override bool CanBeCopied => true;

    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        //if(term)
        throw new NotImplementedException();
    }
}

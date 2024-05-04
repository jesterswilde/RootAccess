using System.Collections.Generic;
using UnityEditor.Rendering;

public class PRG_View : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term) {
        if(arguments.Count == 0)
            return new CommandResult() { Text = $"{TColor.Error} Error: No argument supplied.  Use 'man' for documentation" };
        var pipe = term.FS.GetLocalProgram("pipe") as PRG_Pipe ?? throw new System.Exception("View requires pip and pipe not found");
        if(arguments[0] == "network"){
            pipe.ConnectFiles(term.Monitor.Network, term.Monitor.Monitor, term.FS);
            return new CommandResult() { Text = $"{TColor.Access}Connected to Network{TColor.Close}" };
        }
        if(arguments[0] == "forum"){
            pipe.ConnectFiles(term.Monitor.Forum, term.Monitor.Monitor, term.FS);
            return new CommandResult() { Text = $"{TColor.Access}Connected to Forum{TColor.Close}" };
        }
        throw new System.Exception("Invalid argument.");
    }
}
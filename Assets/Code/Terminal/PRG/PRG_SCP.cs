using System.Collections.Generic;

public class PRG_SCP : GameProgram
{
    public override string CompleteProcess(GameFile file, Terminal term)
    {
        UnityEngine.Debug.Log("Completed scp");
        term.AddFile(Instantiate(file));
        return $"Completed copying ${file.FileName}";
    }
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if(arguments.Count == 0)
            return new CommandResult() { Text = $"{TColor.Error} Must include a target file. Ussage: scp <filename> {TColor.Close}" };
        var file = ResolvePath(arguments[0], term);
        if (file == null)
            return new CommandResult() { Text = $"{TColor.Error} No file by that name exists {TColor.Close}" };
       
        if(term.Node == null)
            return new CommandResult() { Text = "{TColor.Error} Only works in nodes {TColor.Close}" };
        if (!term.Node.Role.HasPermission(file.permissionRequired))
            return new CommandResult() { Text = $"{TColor.Error} You lack required permissions. Requires {file.permissionRequired.ToString()}. Your current role is: {term.Node.Role.ToString()} {TColor.Close}" };
        if (!file.CanBeCopied) 
            return new CommandResult() { Text = "{TColor.Error} File is not copyable {TColor.Close}", };

        var process = term.Node.StartProcess("scp", file, file.FileSize);
        return new CommandResult()
        {
            Text = $"Starting to copy {file.FileName}",
            Process = process,
        };
    }
}

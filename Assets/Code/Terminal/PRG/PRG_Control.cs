using System.Collections.Generic;

public class PRG_Control : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if (Terminal.PowerBrick.IsBusy)
            return new CommandResult() { Text = $"{TColor.Error}Powerbrick is currently already CTRLing something. Use 'free_ctrl' to free your PowerBrick to control something new.{TColor.Close}" };
        var file = term.GetFile(arguments[0]);
        if (file == null)
            return new CommandResult() { Text = $"{TColor.Error} No file by name of {arguments[0]}{TColor.Close}" };
        if (!(file is ControlFile))
            return new CommandResult() { Text = $"{TColor.Error} File is not a .ctl file. CTRL cannot run it.{TColor.Close}" };
        if (!term.Node.Role.HasPermission(file.permissionRequired))
            return new CommandResult() { Text = $"{TColor.Error} You lack required permissions. Requires {file.permissionRequired.ToString()}. Your current role is: {term.Node.Role.ToString()} {TColor.Close}" };

        var ctl = file as ControlFile;
        ctl.AttachToControlPanel(Terminal.PowerBrick);
        return new CommandResult() { Text = $"PowerBrick is now in CTRL of {ctl.ObjName}" };
    }
}

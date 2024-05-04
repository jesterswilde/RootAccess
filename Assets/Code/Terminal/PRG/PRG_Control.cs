using System.Collections.Generic;

public class PRG_Control : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if (Terminal.PowerBrick.IsBusy)
            throw new TerminalError("Powerbrick is currently already CTRLing something. Use 'free_ctrl' to free your PowerBrick to control something new.");
        var file = term.GetFile(arguments[0]);
        if (file == null)
            throw new TerminalError($"No file by name of {arguments[0]}");
        if (file is not ControlFile)
            throw new TerminalError("File is not a .ctl file. CTRL cannot run it.");
        if (!term.Node.Role.HasPermission(file.permissionRequired))
            throw new TerminalError($"You lack required permissions. Requires {file.permissionRequired.ToString()}. Your current role is: {term.Node.Role.ToString()}");

        var ctl = file as ControlFile;
        ctl.AttachToControlPanel(Terminal.PowerBrick);
        return new CommandResult() { Text = $"PowerBrick is now in CTRL of {ctl.ObjName}" };
    }
}

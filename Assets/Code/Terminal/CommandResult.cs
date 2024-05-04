using System;

public class CommandResult
{
    public string Text;
    public GameProcess Process;
    public static CommandResult PermissionDenied(GameFile file, Terminal term) => new CommandResult() { Text = $"{TColor.Error} You lack required permissions. Requires {file.permissionRequired.ToString()}. Your current role is: {term.Node.Role.ToString()} {TColor.Close}" };
    public static CommandResult FileNotFound() => new CommandResult() { Text = $"{TColor.Error} No file by that name exists {TColor.Close}" };
    public static CommandResult WrapError(string error) => new CommandResult() { Text = $"{TColor.Error} {error} {TColor.Close}" }; 
}


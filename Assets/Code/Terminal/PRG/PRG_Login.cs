using System;
using System.Collections.Generic;
using System.Linq;

public class PRG_Login : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term){
        var result = new CommandResult() { 
            Process = new LoginProcess() {
                IsIdle = false,
                ProgramPath = GetPath(),
                Node = term.Node,
                RequiresUserInput = true,
                Username = arguments.Count > 0 ? arguments[0] : null,
                Password = arguments.Count > 1 ? arguments[0] : null,
            }
        };
        string text = "Please Enter Username:";
        bool endProcess = false;
        if(arguments.Count >= 1)
            (endProcess, text) = HandleEnterUsername(arguments[0], result.Process as LoginProcess);
        if(arguments.Count >= 2 && !endProcess){
            text = HandleEnterPassword(arguments[1], result.Process as LoginProcess);
            endProcess = true;
        }
        result.Text = text;
        result.Process.RequiresUserInput = !endProcess;
        return result;
    }
    public override void HandleUserInput(string input, GameProcess process){
        if (process is not LoginProcess loginProcess)
            throw new TerminalError("Invalid process type");
        string text;
        bool endProcess;
        if (loginProcess.Username == null)
            (endProcess, text) = HandleEnterUsername(input, loginProcess);
        else{
            text = HandleEnterPassword(input, loginProcess);
            endProcess = true;
        }
        Terminal.T.TryPrint(text);
        Terminal.T.ClearInput();
        if(endProcess)
            process.RequiresUserInput = false;
    }
    (bool, string) HandleEnterUsername(string username, LoginProcess process){
        var node = Terminal.T.Node ?? throw new System.Exception("You are already logged in on your home node.");
        process.Username = username;
        var user = node.Users.FirstOrDefault(u => u.Username == username);
        if(user != null && user.CachedPassword == user.Password)
            return (true, LoginWithUser(user));
        node.LoginAttempts++;
        return (false, "Please Enter Password:");
    }
    string HandleEnterPassword(string password, LoginProcess process){
        var node = Terminal.T.Node ?? throw new System.Exception("You are already logged in on your home node.");
        var user = node.Users.FirstOrDefault(u => u.Username == process.Username);
        if(user == null || user.Password != password){
            node.LoginAttempts++;
            return $"Invalid Username or Password\nFailed login attempts: {Terminal.T.Node.LoginAttempts}";
        }
        return LoginWithUser(user);
    }
    string LoginWithUser(User user){
        Terminal.T.Node.CurrentUser = user;
        user.CachedPassword = user.Password;
        return Terminal.T.Node.LoginMessage.Replace("$username",$"{user.Role.Color()}{user.Username}{TColor.Close}");
    }


    public class LoginProcess : GameProcess
    {
        public string Username;
        public string Password;
    }
}
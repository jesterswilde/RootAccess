using System.Collections.Generic;
using System.Linq;

public class PRG_Login : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term)=>
        new CommandResult() { 
            Text = "Please Enter Username:",
            Process = new LoginProcess() {
                IsIdle = false,
                ProgramPath = GetPath(),
                node = term.Node,
                RequiresUserInput = true,
            }
        };
    public override void HandleUserInput(string input, GameProcess process, Terminal term){
        var loginProcess = process as LoginProcess;
        if(loginProcess == null)
            throw new System.Exception("Invalid process type");
        var node = term.Node ?? throw new System.Exception("You are already logged in on your home node.");
        if (loginProcess.Username == null){
            loginProcess.Username = input;
            var user = node.Users.FirstOrDefault(u => u.Username == loginProcess.Username);
            if(user != null && user.CachedPassword == user.Password){ // we already have logged in as this user before
                node.CurrentUser = user;
                term.TryPrint(node.LoginMessage.Replace("$username", user.Username));
            }
            else
                term.TryPrint("Please Enter Password:");
        }
        else{
            loginProcess.Password = input;
            var user = node.Users.FirstOrDefault(u => u.Username == loginProcess.Username);
            if(user == null || user.Password != loginProcess.Password){
                term.TryPrint($"Invalid Username or Password\nFailed Login Attempts: {++node.LoginAttempts}\nPlease Enter Username:");
                loginProcess.Username = null;
                loginProcess.Password = null;
            }
            else{
                node.CurrentUser = user;
                term.TryPrint(node.LoginMessage.Replace("$username", user.Username));
            }
        }
    }


    public class LoginProcess : GameProcess
    {
        public string Username;
        public string Password;
    }
}
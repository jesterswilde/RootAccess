using System.Collections.Generic;

public class PRG_Tut : GameProgram
{
    public override bool CanBeCopied => true;

    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if(arguments.Count == 0)
        {
            UnityEngine.Debug.Log(term);
            UnityEngine.Debug.Log(TColor.Access);
            var nodeName = (term.Node == null) ? "No node" : term.Node.Name;
            string overview = $"Hey! Welcome to the terminal and the {TColor.Access}connected net{TColor.Close}.\n" +
                $"The net is a series of nodes. You are currently connected to node: {nodeName} " +
                $"Nodes contain files that you can access or copy. Nodes are also connected to other nodes that you can link into to move around. There are lots of cool things out on the {TColor.Access}connected net{TColor.Close} to explore.\n" +
                $"\nRun 'prg' to list all programs you have. You can use man (short for manual) on any program to find out what they do and how to use them" +
                $"\nRun 'tut node' to learn more about nodes\nRun 'tut connection' to learn more about connections\nRun 'tut role' to learn more about roles and permissions";
            return new CommandResult() { Text = overview };
        }
        if(arguments[0] == "node")
        {
            string nodeText = $"Nodes are core of any network. They can contain data, allow you to access remote services (like turning on the coffee machine.) and access other nodes" +
                $"\nRun 'node' to get info about the current node you're on. Such as it's name, as well as the hardware and software it's running" +
                $"\nRun 'ls' to get a list of all known files on a computer. But your terminal might not have indexed all files yet. Run 'search' to look for all files on a node. This may take a bit of time." +
                $"\nRun 'cat <filename>' will view the contents of a file\nRun 'man <filename> will tell you about the file type.\nRun 'scp <filename>' to copy a file to your computer for later usage " +
                $"You cannot interact with a file you don't have the proper permissions to access. If you can interact with a file it wil be {TColor.Access}Access Green. {TColor.Close}" +
                $"\nRun 'tut connection' to learn about connecting to other nodes.\n Run 'tut roles' to learn about roles";
            return new CommandResult() { Text = nodeText };
        }
        if(arguments[0] == "connection")
        {
            string conText = $"Nodes live in a network and are connected to other nodes through a connection." +
                $"You can Run 'scan' to look for node connections. This may take a bit of time.\n" +
                $"The 'link' command is used to view and move through know connections. \nRun 'link' by itself to view  a list of known connections.\n" +
                $"Run 'link <nodeName>' to link into a that node. You must have the appropriate permissions to link into a node. If you have access, the node will be {TColor.Access}Access Green{TColor.Close}";
            return new CommandResult() { Text = conText };
        }
        if (arguments[0] == "roles" || arguments[0] == "role")
        {
            string roleText = $"Every user (you) has a role, or set of permissions, on each node you visit. The three roles are Guest {TColor.Admin}Admin{TColor.Close} and {TColor.Root}Root{TColor.Close} " +
                $"By default, you start out as Guest. Please contact your administrator if you believe you have the wrong permissions. Every file or connection has a level of permissions required to use it. If you can use a file or connection it will be {TColor.Access} Access Green{TColor.Close}, a very soothing color." +
                $"\nIf it requires {TColor.Admin}Admin{TColor.Close} and you are not {TColor.Admin}Admin{TColor.Close} or higher, it will appear in {TColor.Admin}Warning Yellow{TColor.Close}." +
                $"\nIf it requires {TColor.Root}Root{TColor.Close} and you are not {TColor.Root}Root{TColor.Close}, it will appear in {TColor.Root}Danger Orange{TColor.Close}." +
                $"\nMaking hardware and software is difficult and there are nefarious actors out in the world. It is for this reason it's important to not run random programs on nodes. Who knows what will happen.";
            return new CommandResult() { Text = roleText };
        }
        return new CommandResult() { Text = $"{TColor.Error}No tutorial for {arguments[0]} exists.{TColor.Close}"};
    }
}

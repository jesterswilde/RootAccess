using System.Collections.Generic;

public class PRG_Whoami : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term) =>
        new CommandResult() { Text = term.CurrentUser };
}
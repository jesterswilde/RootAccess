using System.Collections.Generic;
using System.Text.RegularExpressions;

public class PRG_Grep : GameProgram
{
    public override CommandResult RunFromPipe(string pipedData, List<string> arguments, Terminal term)
    {
        arguments.Insert(1, pipedData);
        return Run(arguments, term);
    }
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        if (arguments.Count < 2)
            return new CommandResult() { Text = $"{TColor.Error} Must supply a search term and a file to search{TColor.Close}" };
        string toGrep = "";
        if(arguments[1].StartsWith("\"") && arguments[1].EndsWith("\""))
            toGrep = arguments[1].Substring(1, arguments[1].Length - 2);
        else{
            var file = term.GetFile(arguments[1]);
            if (file == null)
                return new CommandResult() { Text = "File Not Found" };
            toGrep = file.Text;
        }
        var lines = toGrep.Split('\n');
        var results = new List<string>();
        foreach (var line in lines)
            if (Regex.IsMatch(line, arguments[0]))
                results.Add(line);
        if (results.Count == 0)
            return new CommandResult() { Text = "No Results Found" };
        return new CommandResult() { Text = string.Join("\n", results) };
    }
}
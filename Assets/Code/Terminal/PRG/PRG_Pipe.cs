using System.Collections.Generic;
using UnityEngine;

public class PRG_Pipe : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        var o = ResolvePath(arguments[0], term);
        var i = ResolvePath(arguments[1], term);
        if(o == null)
            return new CommandResult() { Text = $"{TColor.Error}Output not found{TColor.Close}" };
        if(i == null)
            return new CommandResult() { Text = $"{TColor.Error}Input not found{TColor.Close}" };
        var outputFile = o as OutputFile;
        if(outputFile == null)
            return new CommandResult() { Text = $"{TColor.Error}First argument, Output, is not an Output File{TColor.Close}" };
        var inputFile = i as InputFile;
        if(inputFile == null)
            return new CommandResult() { Text = $"{TColor.Error}Second argument, Input, is not an Input File{TColor.Close}" };
        
        if(!term.Node.Role.HasPermission(outputFile.permissionRequired))
            return new CommandResult() { Text = $"{TColor.Error}You do not have permission to access the output file{TColor.Close}" };
        if(!term.Node.Role.HasPermission(inputFile.permissionRequired))
            return new CommandResult() { Text = $"{TColor.Error}You do not have permission to access the input file{TColor.Close}" };

        var result = ConnectFiles(outputFile, inputFile, term);
        return new CommandResult() { Text = result };
    }

    string ConnectFiles(OutputFile outputFile, InputFile inputFile, Terminal term)
    {
        GameObject go = new GameObject();
        go.name = $"Pipe_{outputFile.FileName}_{inputFile.FileName}";
        var pipe = go.AddComponent<PipeFile>();
        pipe.Setup(inputFile.Input, outputFile.Output);
        term.Node.AddFile(pipe);
        return $"Connected ${outputFile.FileName} to ${inputFile.FileName}";
    }
}
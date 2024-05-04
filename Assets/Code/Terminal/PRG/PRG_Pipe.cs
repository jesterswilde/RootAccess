using System.Collections.Generic;
using UnityEngine;

public class PRG_Pipe : GameProgram
{
    public override CommandResult Run(List<string> arguments, Terminal term)
    {
        var o = term.GetFile(arguments[0]) as OutputFile;
        var i = term.GetFile(arguments[1]) as InputFile;
        if(o == null)
            throw new TerminalError("First argument, Output, is not an Output File");
        if(i == null)
            throw new TerminalError("Second argument, Input, is not an Input File");
        
        var result = ConnectFiles(o, i, term.Node);
        return new CommandResult() { Text = result };
    }

    public string ConnectFiles(OutputFile outputFile, InputFile inputFile, Node node)
    {
        GameObject go = new GameObject();
        go.name = $"Pipe_{outputFile.FileName}_{inputFile.FileName}";
        var pipe = go.AddComponent<PipeFile>();
        pipe.FileName = outputFile.FileName + "|" + inputFile.FileName;
        pipe.IsFound = true;
        pipe.Setup(inputFile.Input, outputFile.Output, node);
        node.AddFile(pipe);
        return $"Connected ${outputFile.FileName} to ${inputFile.FileName}";
    }
}
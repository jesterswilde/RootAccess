#pragma warning disable 0649
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
public class ExecutorFile : GameFile {
    Dictionary<string, string> _commands;
    [SerializeField]
    List<CommandInfo> _commandInfos;
    [SerializeField]
    string defaultCommand;

    public void SetCommand(string key, string command){
        if(key == "" || key == null)
            key = defaultCommand;
        if(!_commands.ContainsKey(key)){
            throw new Exception("Command not found");
        }
        _commands[key] = command;
    }

    public string ViewCommands(){
        var commands = "";
        foreach(var c in _commandInfos){
            commands += $"{c.Name} - {c.Description}\n";
        }
        return commands;
    }
    [Button]
    public void ExecuteCommand(string key){
        if(key == "" || key == null) key = defaultCommand;
        if(!_commands.ContainsKey(key)){
            throw new Exception("Command not found");
        }
        var commands = _commands[key].Split(';');
        foreach(var c in commands){
            var (fullFilePath, args) = c.Split(' ');
            var (filePath, channel, _) = fullFilePath.Split('/');
            var file = GetNode().GetFile(filePath);
            switch (file){
                case GameProgram program:
                    program.Run(args as List<string>, Terminal.T);
                    break;
                case ControlFile control:
                    control.ExecuteCommand(channel, args as List<string>);
                    break;
                default:
                    throw new Exception("File not found");
            }
        }
    }
    [Serializable]
    struct CommandInfo{
        public string Name;
        public string Description;
        public string Command;
    }

    void Awake(){
        _commands = new Dictionary<string, string>();
        foreach(var c in _commandInfos){
            _commands.Add(c.Name, c.Command);
        }
    }
}

using System;

public class TerminalError : Exception { 
    public TerminalError(string message) : base(message) { }
}
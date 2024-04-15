#pragma warning disable 0649
using System;
using System.Collections.Generic;

public class DialogueOption{
    public string Text;
    public Action OnClick;
    public IEnumerable<string> Classes;
}

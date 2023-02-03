using System.Collections.Generic;
using System.Linq;

public class AutoComplete
{
    List<string> options;
    string writtenWord;
    int index = 0;
    bool isClear = true;
    public void Clear()
    {
        if (isClear)
            return;
        isClear = true;
        index = 0;
    }
    public string PressedTab(Terminal term, string _wordStart)
    {
        if (isClear)
        {
            CreateOptions(term, _wordStart);
            isClear = false;
            index = 0;
        }
        if(options.Count > 0)
        {
            var word = options[index];
            index = (index + 1) % options.Count;
            return word;
        }
        return _wordStart;
    }
    void CreateOptions(Terminal term, string _wordStart)
    {
        writtenWord = _wordStart;
        options = term.LocalFiles.Select(f => f.FileName).Where(w => w.StartsWith(_wordStart)).ToList();
        var nodeNames = term.KnownNodes.Select(n => n.Name);
        var nodeFiles = term.NodeFiles.Select(f => f.FileName);
        options.AddRange(nodeNames);
        options.AddRange(nodeFiles);
        index = 0;
    }
}

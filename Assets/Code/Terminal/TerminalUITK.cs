#pragma warning disable 0649
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;


public class TerminalUITK : MonoBehaviour{
     AutoComplete ac = new AutoComplete();
    [SerializeField]
    UIDocument ui;
    VisualElement _output;
    VisualElement _loadBarParent;
    Label _path;
    Label _inputLabel;
    string _input;
    int _caratPosition = 0;
    LoadingBar loadingBar;
    [SerializeField]
    Terminal terminal;
    void ClearInput(){
        _input = "";
        _caratPosition = 0;
        UpdateInput();
    }
    void UpdateInput(){
        _inputLabel.text = _input.Insert(_caratPosition, "<b>|</b>");
        UpdatePath(terminal.Node);
    }
    void AddChar(char c){
        _input = _input.Insert(_caratPosition, c.ToString());
        _caratPosition++;
        UpdateInput();
    }
    void DeleteChar(){
        if(_caratPosition > 0){
            _input = _input.Remove(_caratPosition - 1, 1);
            _caratPosition--;
            UpdateInput();
        }
    }

    int GetEndOfWord(string[] words, int index){
        var count = 0;
        for(var i = 0; i < index; i++){
            count += words[i].Length + 1;
        }
        return count + words[index].Length;
    }
    (string word, int index) GetSelectedWord(string[] words){
        var index = 0;
        var count = 0;
        foreach(var word in words){
            if(count + word.Length >= _caratPosition){
                return (word, index);
            }
            count += word.Length + 1;
            index++;
        }
        return (null, -1);
    }

    internal TerminalUITK Attach(Terminal t)
    {
        terminal = t;
        return this;
    }
    void ReadFromStdOut(string text)
    {
        Label l = new Label(text);
        l.AddToClassList("command");
        _output.Add(l);
    }
    void OnStartProcess(GameProcess process)
    {
        if(process.HasLoadingBar){
            loadingBar = new LoadingBar();
            _loadBarParent.Add(loadingBar);
        }

    }
    void OnTickProcess(GameProcess process)
    {
        if(process.HasLoadingBar)
            loadingBar.UpdateProgress(process.Progress);
    }
    void OnEndProcess(GameProcess process)
    {
        if(loadingBar != null)
            _loadBarParent.Remove(loadingBar);
    }
    void UpdatePath(Node node)
    {
        _path.text = terminal.FS.PausingForInput ? "" : terminal.Path;
    }
    void OnModeChange(ControlMode mode)
    {
    }
    void Listen()
    {
        if(Input.anyKey && !Input.GetKeyDown(KeyCode.Tab)){
            ac.Clear();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            terminal.AcceptInput(_input);
            ClearInput();
            return;
        }
        if (Input.GetKeyDown(KeyCode.Backspace)){
            DeleteChar();
            return;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            _caratPosition = Mathf.Max(0, _caratPosition - 1);
            UpdateInput();
            return;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            _caratPosition = Mathf.Min(_input.Length, _caratPosition + 1);
            UpdateInput();
            return;
        }
        if (Input.anyKeyDown && Input.inputString.Length > 0){
            AddChar(Input.inputString[0]);
            return;
        }
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            var words = _input.Split(" ");
            if (words.Length == 0)
                return;
            var (word, index) = GetSelectedWord(words);
            var option = ac.PressedTab(Terminal.T, word);
            words[index] = option;
            _input = string.Join(" ", words);
            _caratPosition = GetEndOfWord(words, index);
            UpdateInput();
        }
    }
    private void Update()
    {
        if (ControlManager.Mode != ControlMode.Terminal)
            return;
        Listen();
    }
    void Awake(){
        _output = ui.rootVisualElement.Q<VisualElement>("output");
        _path = ui.rootVisualElement.Q<Label>("path");
        _inputLabel = ui.rootVisualElement.Q<Label>("input");
        _loadBarParent = ui.rootVisualElement.Q<VisualElement>("loadingBarParent");
    }
    private void Start()
    {
        if(terminal == null)
            terminal = Terminal.T;
        terminal.OnStdOut += ReadFromStdOut;
        terminal.OnNodeChange += UpdatePath;
        terminal.FS.OnStartProcess += OnStartProcess;
        terminal.FS.OnTickProcess += OnTickProcess;
        terminal.FS.OnEndProcess += OnEndProcess;
        terminal.OnClearInput += ClearInput;
        UpdatePath(terminal.Node);
        //FocusInput();
        ControlManager.OnModeChange += OnModeChange;
        ClearInput();
        UpdateInput();
    }   
}
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TerminalGUI : MonoBehaviour
{
    [SerializeField]
    string actualText;
    [SerializeField]
    TMPro.TMP_InputField input;
    [SerializeField]
    TMPro.TextMeshProUGUI output;
    [SerializeField]
    TMPro.TextMeshProUGUI path;
    [SerializeField]
    Transform outputParent;
    [SerializeField]
    LoadingBar loadingBarPrefab;
    LoadingBar loadingBar;
    [SerializeField]
    Terminal terminal;

    void Listen()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            output.text += $"\n{path.text.Split(" ")[1]} {input.text}\n";
            terminal.ExecuteCommand(input.text);
            input.text = "";
            FocusInput();
        }
    }

    internal TerminalGUI Attach(Terminal t)
    {
        terminal = t;
        return this;
    }

    public void FocusInput()
    {
        if(input == null)
        {
            Debug.Log("Input was destroyed");
            return;
        }
        input.ActivateInputField();
        input.Select();
    }
    void ReadFromStdOut(string text)
    {
        output.text += text;
    }
    void OnStartProcess(GameProcess process)
    {
        loadingBar = Instantiate(loadingBarPrefab, outputParent);
    }
    void OnTickProcess(GameProcess process)
    {
        loadingBar.UpdateBar(process);
    }
    void OnEndProcess(GameProcess process)
    {
        Destroy(loadingBar.gameObject);
    }
    void UpdatePath(Node node)
    {
        if (node == null)
            path.text = "# HOME>";
        else
            path.text = $"# {node.Name}>";
        LayoutRebuilder.ForceRebuildLayoutImmediate(path.transform as RectTransform);
    }
    void OnModeChange(ControlMode mode)
    {
        if(mode == ControlMode.World)
             EventSystem.current.SetSelectedGameObject(null);
        if (mode == ControlMode.Terminal)
            FocusInput();
    }
    private void Update()
    {
        Listen();
    }
    private void Start()
    {
        terminal.OnStdOut += ReadFromStdOut;
        terminal.OnNodeChange += UpdatePath;
        terminal.OnStartProcess += OnStartProcess;
        terminal.OnTickProcess += OnTickProcess;
        terminal.OnEndProcess += OnEndProcess;
        UpdatePath(terminal.Node);
        //FocusInput();
        ControlManager.OnModeChange += OnModeChange;
    }
}

public class TColor
{
    public static string Error = "<color=\"red\">";
    public static string Access = "<color=\"green\">";
    public static string Admin = "<color=\"yellow\">";
    public static string Root = "<color=\"orange\">";
    public static string Close = "</color>";
}

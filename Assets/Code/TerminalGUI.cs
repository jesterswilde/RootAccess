using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Febucci;

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
    public void FocusInput()
    {
        input.ActivateInputField();
        input.Select();
    }
    void ReadFromStdOut(string text)
    {
        output.text += text;
    }
    void UpdatePath(Node node)
    {
        if (node == null)
            path.text = "HOME>";
        else
            path.text = $"# {node.Name}>";
        LayoutRebuilder.ForceRebuildLayoutImmediate(path.transform as RectTransform);
    }
    private void Update()
    {
        Listen();
    }
    private void Start()
    {
        terminal.OnStdOut += ReadFromStdOut;
        terminal.OnNodeChange += UpdatePath;
        UpdatePath(terminal.Node);
        FocusInput();
        //Febucci.UI.TextAnimator.EnableAppearances(false);
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

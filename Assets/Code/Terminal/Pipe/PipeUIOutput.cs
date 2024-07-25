#pragma warning disable 0649
using UnityEngine.UIElements;

public class PipeUIOutput : PipeOutput{
    UIDocument  _doc;
    IUIController _controller;
    PanelSettings _panel;
    int _settingsIndex;
    public override void Connect(PipeInput input) {
        base.Connect(input);
        if(_connections.Count == 1){
            _doc.enabled = true;
            (_settingsIndex, _panel) = PanelManager.Link(_doc);
            _controller?.Initialize(_doc);
        }
        if(input is PipeVideoInput monitor){
            monitor.SetTexture(_panel.targetTexture);
        }
        else
            throw new System.Exception("Unsupported input type: " + input.GetType().Name);
    }
    public override void Disconnect(PipeInput input)
    {
        PanelManager.Unlink(_settingsIndex);
        if(input is PipeVideoInput monitor){
            monitor.SetTexture(null);
        }
        _connections.Remove(input);
        if(_connections.Count == 0){
            _doc.enabled = false;
            _panel = null;
            _controller?.Teardown();
        }
        base.Disconnect(input);
    }
    public PipeUIOutput(UIDocument doc, IUIController cont = null){
        _doc = doc;
        _controller = cont;

    }
}
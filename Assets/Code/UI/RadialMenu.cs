#pragma warning disable 0649
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class RadialMenu : MonoBehaviour{ 
    bool _isOpen;
    [SerializeField]
    float _width;
    [SerializeField]
    UIDocument _doc;
    [SerializeField]
    List<string> defaultText;
    [SerializeField]
    Sprite defaultIcon;
    Vector2[] _positions = new Vector2[]{
        new(0, 1f), new(2f, 1), new(1f, 0), new(1f, 2f), new(0, 0), new(2f, 0), new(0, 2f), new(2f, 2f)
    };
    public void Open(RadialMenuOption[] options){
        _isOpen = true;
        _doc.enabled = true;
        _doc.rootVisualElement.RegisterCallback<GeometryChangedEvent>(e =>{
            var menu = BuildMenu(options);
            var panelWidth = _doc.rootVisualElement.layout.width;
            var panelHeight = _doc.rootVisualElement.layout.height;
            var offset = _width / 2;
            var x = Screen.width / panelWidth;
            var y = Screen.height / panelHeight;
            var mousePos = new Vector2(Input.mousePosition.x / x, Input.mousePosition.y / y);

            mousePos.x = Mathf.Min(mousePos.x, panelWidth - offset);
            mousePos.x = Mathf.Max(mousePos.x, offset);
            mousePos.y = Mathf.Min(mousePos.y, panelHeight - offset);
            mousePos.y = Mathf.Max(mousePos.y, offset);


            ////center the menu at menuX, menuY
            menu.style.left = mousePos.x - offset;
            menu.style.top = panelHeight - mousePos.y - offset;
            menu.style.position = Position.Absolute;
            _doc.rootVisualElement.Add(menu);
        });
    }
    VisualElement BuildMenu(RadialMenuOption[] options){
        var menu = new VisualElement();
        menu.AddToClassList("radial-menu");
        menu.style.width = _width;
        menu.style.height = _width;
        var optionWidth = _width / 3;
        var optionOffset = optionWidth / 2;
        for(int i = 0; i < options.Length; i++){
            var option = options[i];
            option.OnSelected = () => {
                option.Callback();
                Close();
            };
            var optionUI = new RadialMenuOptionUI(option, optionWidth);
            var position = _positions[i];
            optionUI.style.left = position.x * optionWidth;
            optionUI.style.top = position.y * optionWidth;
            menu.Add(optionUI);
        }
        return menu;
    }

    public void Close(){
        _doc.rootVisualElement.Clear();
        _doc.enabled = false;
        _isOpen = false;
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.G)){
            if(_isOpen)
                Close();
            else{
                var options = defaultText.Select((t, i) => new RadialMenuOption{
                    Text = t,
                    Icon = defaultIcon,
                    Callback = () => Debug.Log($"Selected {t}")
                }).ToArray();
                Open(options);
            }
        }
    }
}

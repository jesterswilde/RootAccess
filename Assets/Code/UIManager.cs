#pragma warning disable 0649
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour { 
    public static UIManager T { get; private set; }
    [SerializeField]
    UIDocument _doc;
    bool _isOpen = false;
    [SerializeField]
    VisualTreeAsset _sidebarPrefab;
    [SerializeField]
    VisualElement _sidebar;
    public void OpenSidebar(){
        RedrawSidebar();
    }
    public void CloseSidebar(){
        if(_sidebar != null)
            _doc.rootVisualElement.Remove(_sidebar);
    }
    public void RedrawSidebar(){
        _sidebar = _sidebarPrefab.CloneTree();
        _doc.rootVisualElement.Add(_sidebar);
        if(Player.T.Outfit.Badge != null){
            var badge = Player.T.Outfit.Badge;
            var badgeEl = _sidebar.Q<VisualElement>("Badge");
            badgeEl.style.backgroundImage = badge.Sprite.texture;
        }else{
            var badgeEl = _sidebar.Q<VisualElement>("Badge");
            badgeEl.style.backgroundImage = null;
        }
    }

    public VisualElement OpenWindow(VisualTreeAsset tree, int prioroity = 0){
        _isOpen = true;
        _doc.enabled = true;
        var el = tree.CloneTree();
        _doc.rootVisualElement.RegisterCallback<GeometryChangedEvent>(e =>{
            _doc.rootVisualElement.Add(el);
            el.style.width = _doc.rootVisualElement.layout.width;
            el.style.height = _doc.rootVisualElement.layout.height;
            ControlManager.EnterMode(ControlMode.UI);
        });
        return el;
    }
    public void Close(){
        _isOpen = false;
        _doc.enabled = false;
        ControlManager.EnterMode(ControlMode.World);
    }
    void Start(){
        _doc.enabled = false;
    }
    void Awake(){
        if(T != null){
            Destroy(this);
            return;
        }
        T = this;
        _doc.enabled = false;
    }
}
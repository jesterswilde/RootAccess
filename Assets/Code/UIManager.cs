#pragma warning disable 0649
using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour { 
    public static UIManager T { get; private set; }
    [SerializeField]
    UIDocument _doc;

    //public bool IsOpen { get; private set; } = false;
    [SerializeField]
    VisualTreeAsset _sidebarPrefab;
    VisualElement _sidebar;
    [SerializeField, ReadOnly]
    bool _isSidebarOpen = false;
    public void OpenSidebar(){
        _isSidebarOpen = true;
        RedrawSidebar();
    }
    public void CloseSidebar(){
        _isSidebarOpen = false;
        if(_sidebar != null)
            _doc.rootVisualElement.Remove(_sidebar);
        _sidebar = null;
    }
    public void RedrawSidebar(){
        if(!_isSidebarOpen)
            return;
        if(_sidebar != null)
            _doc.rootVisualElement.Remove(_sidebar);
        _sidebar = _sidebarPrefab.CloneTree();
        _doc.rootVisualElement.Add(_sidebar);
        if(Player.T.Outfit.Badge != null){
            var badge = Player.T.Outfit.Badge;
            var badgeEl = _sidebar.Q<VisualElement>("BadgeContainer");
            badgeEl.style.backgroundImage = badge.Sprite.texture;
        }else{
            var badgeEl = _sidebar.Q<VisualElement>("BadgeContainer");
            badgeEl.style.backgroundImage = null;
            badgeEl.Add(new Label("No badge"));
        }
        var questCont = _sidebar.Q("QuestContainer");
        questCont.Clear();
        Debug.Log($"Has active quests: {JournalManager.T.HasaActiveQuests}");
        if(JournalManager.T.HasaActiveQuests)
            foreach(var q in JournalManager.T.GetQuestDescriptions())
                questCont.Add(new Label(q));
        else
            questCont.Add(new Label("No active quests"));
    }

    public VisualElement OpenWindow(VisualTreeAsset tree, int prioroity = 0){
        //_doc.enabled = true;
        var el = tree.CloneTree();
        _doc.rootVisualElement.RegisterCallback<GeometryChangedEvent>(e =>{
            _doc.rootVisualElement.Add(el);
            el.style.width = _doc.rootVisualElement.layout.width;
            el.style.height = _doc.rootVisualElement.layout.height;
            ControlManager.EnterMode(ControlMode.UI);
        });
        return el;
    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.P))
            if(_isSidebarOpen)
                CloseSidebar();
            else
                OpenSidebar();
            
    }
    public void Close(){
        //_doc.enabled = false;
        ControlManager.EnterMode(ControlMode.World);
    }
    void Awake(){
        if(T != null){
            Destroy(this);
            return;
        }
        T = this;
        //_doc.enabled = false;
    }

}
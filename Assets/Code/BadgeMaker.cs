#pragma warning disable 0649
using UnityEngine;
using UnityEngine.UIElements;

public class BadgeMaker : MonoBehaviour, IInteractable{
    public static BadgeMaker T { get; private set; }
    [SerializeField]
    Badge[] _badges;
    [SerializeField]
    VisualTreeAsset _badgeSelector;
    int _selectedBage = 0;
    public Badge SelectedBadge => _badges[_selectedBage];
    VisualElement _badgeContainer;
    public void GotInteracted(){
        DrawBadgeSelector();
    }
    public void DrawBadgeSelector(){
        Debug.Log("Drawing badge selector");    
        var selector = UIManager.T.OpenWindow(_badgeSelector);
        _badgeContainer = selector.Q("Badge-Container");
        selector.Q("Left").RegisterCallback<ClickEvent>(e => ChangeBadge(-1));
        selector.Q("Right").RegisterCallback<ClickEvent>(e => ChangeBadge(1));
        selector.Q("Accept").RegisterCallback<ClickEvent>(e => Accept());
        selector.Q("Cancel").RegisterCallback<ClickEvent>(e => Cancel());
        DrawBadge(SelectedBadge);
    }
    void Accept(){
        Player.T.Outfit.AddBadge(SelectedBadge);
        Close();
    }
    void Cancel(){
        Close();
    }
    public void ChangeBadge(int mod){
        _selectedBage += mod;
        if(_selectedBage < 0)
            _selectedBage = _badges.Length - 1;
        if(_selectedBage >= _badges.Length)
            _selectedBage = 0;
        DrawBadge(SelectedBadge);
    }
    void Close(){
        UIManager.T.Close();
    }
    void DrawBadge(Badge badge){
        _badgeContainer.style.backgroundImage = badge.Sprite.texture;
    }


    void Awake(){
        if(T != null){
            Destroy(this);
            return;
        }
        T = this;
    }
}

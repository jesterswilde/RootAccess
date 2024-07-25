#pragma warning disable 0649
using UnityEngine;
using UnityEngine.UIElements;
using static ForumN.Navigation;

namespace ForumN
{
    public class ForumUI : MonoBehaviour, IUIController {
        public Navigation Navigation {get; private set;}
        UIDocument _doc;
        PageUI _currentPage;
        public VisualElement PageRoot;
        VisualElement _root => _doc.rootVisualElement; 

        void PageChanged(Navigation navigation){
            LoadPage(navigation.CurrentPage);
        }
        void LoadPage(Page page){
            _currentPage?.Hide();
            _currentPage = page switch {
                Page.ForumHome => new HomePageUI(this),
                Page.Thread => new ThreadPageUI(this),
                _ => throw new System.NotImplementedException()
            };
        }
        public void Initialize(UIDocument doc)
        {
            _doc = doc;
            Navigation = new Navigation();
            Navigation.OnPageChange += PageChanged;
            PageRoot = _root.Q<VisualElement>("Page");
            _root.Q<VisualElement>("Title")?.RegisterCallback<ClickEvent>(e => Navigation.CurrentPage = Page.ForumHome);
            LoadPage(Navigation.CurrentPage);
        }

        public void Teardown()
        {
            _doc = null;
            Navigation.OnPageChange -= PageChanged;
            Navigation = null;
        }
    }
}
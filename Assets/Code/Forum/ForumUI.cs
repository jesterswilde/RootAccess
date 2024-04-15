#pragma warning disable 0649
using UnityEngine;
using UnityEngine.UIElements;
using static ForumN.Navigation;

namespace ForumN
{
    public class ForumUI : MonoBehaviour {
        public Navigation Navigation => Forum.T.Navigation;
        [SerializeField]
        UIDocument document;
        PageUI _currentPage;
        public VisualElement PageRoot => document.rootVisualElement;

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
        void Start(){
            Navigation.OnPageChange += PageChanged;
            LoadPage(Navigation.CurrentPage);
            PageRoot.Q<VisualElement>("#Title").RegisterCallback<ClickEvent>(e => Navigation.CurrentPage = Page.ForumHome);
        }
    }
}
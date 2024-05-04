#pragma warning disable 0649
using UnityEngine.UIElements;

namespace ForumN
{
    public abstract class PageUI {
        protected VisualElement _root;
        public virtual void Show(ForumUI forumUI){
            _root = forumUI.PageRoot;
        }
        public virtual void Hide(){
            _root.Clear();
        }
        public PageUI(ForumUI forumUI){
            Show(forumUI);
        }
    }
}
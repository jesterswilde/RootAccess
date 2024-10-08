#pragma warning disable 0649
using UnityEngine.UIElements;

namespace ForumN
{
    public class ThreadPageUI : PageUI {
        Thread _thread;
        VisualElement _container;
        public override void Show(ForumUI forumUI) {
            base.Show(forumUI);
            _thread = forumUI.Navigation.CurrentThread;
            _container = new VisualElement();
            _container.AddToClassList("threadPage");
            _root.Add(_container);
        }
        public ThreadPageUI(ForumUI forumUI) : base(forumUI) { }
    }
}
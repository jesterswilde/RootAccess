#pragma warning disable 0649
using UnityEngine.UIElements;

namespace ForumN
{
    public class ThreadPageUI : PageUI {
        Thread _thread => Forum.T.Navigation.CurrentThread;
        VisualElement _container;
        public override void Show(ForumUI forumUI) {
            base.Show(forumUI);
            _container = new VisualElement();
            _container.AddToClassList("threadPage");
            _root.Add(_container);
        }
        public ThreadPageUI(ForumUI forumUI) : base(forumUI) { }
    }
}
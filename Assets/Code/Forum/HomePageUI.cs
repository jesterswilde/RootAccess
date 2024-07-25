#pragma warning disable 0649
using System.Collections.Generic;
using UnityEngine.UIElements;

namespace ForumN
{
    public class HomePageUI : PageUI {
        VisualElement _container;
        List<Thread> _threads = new();
        ForumUI _parent;
        public override void Show(ForumUI forumUI) {
            base.Show(forumUI);
            _container = new VisualElement();
            _container.AddToClassList("homePage");
            _parent = forumUI;
            _root.Add(_container);
            StubThreads();
            AddThreadsToForumUI();
        }
        void AddThreadsToForumUI()
        {
            foreach (var thread in _threads) {
                var threadSummaryUI = new ThreadSummaryUI(thread, _parent.Navigation);
                _container.Add(threadSummaryUI);
            }
        }
        void StubThreads() {
            var thread1 = new Thread {
                Title = "Welcome to the Forum!",
                CreatedBy = "Anthrax"
            };
            thread1.Posts.Add(new Post { Content = "Welcome to the forum! Feel free to ask any questions you have about the game here.", Username = "Antrhax", Timestamp = 0 });
            _threads.Add(thread1);
            var thread2 = new Thread {
                Title = "The Observatory",
                CreatedBy = "Skyborne"
            };
            thread2.Posts.Add(new Post { Content = "I'm having trouble with the observatory. I can't seem to find the right angle to get the right star.", Username = "Skyborne", Timestamp = 5391382 });
            _threads.Add(thread2);
            var thread3 = new Thread {
                Title = "The FBI",
                CreatedBy = "Ananarcz"
            };
            thread3.Posts.Add(new Post { Content = "Anyone else noice a lot more FBI chatter and raids recently? Don't they ahve anythign better to do?", Username = "Ananarcz", Timestamp = 5391382 });
            _threads.Add(thread3);
        }
        public HomePageUI(ForumUI forumUI) : base(forumUI) { }
    }
}
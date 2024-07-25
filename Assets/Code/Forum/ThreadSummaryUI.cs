#pragma warning disable 0649
using UnityEngine.UIElements;
using UnityEngine;

namespace ForumN
{
    public class ThreadSummaryUI : VisualElement{
        public ThreadSummaryUI(Thread thread, Navigation nav){
            var title = new Label(thread.Title);
            title.RegisterCallback<MouseEnterEvent>(e => {
                Debug.Log("ThreadSummaryUI Clicked");
                nav.GoToThread(thread);
            });
            title.AddToClassList("threadTitle");
            var lastPost = thread.Posts[^1];
            var subTitle = new VisualElement();
            subTitle.AddToClassList("threadSubtitle");
            var createdBy = new Label(thread.CreatedBy);
            var lastModified = new Label(lastPost.Timestamp.ToString());
            var lastModBy = new Label(lastPost.Username);
            subTitle.Add(createdBy);
            subTitle.Add(lastModified);
            subTitle.Add(lastModBy);
            AddToClassList("threadSummary");
            Add(title);
            Add(subTitle);
        }
    }
}
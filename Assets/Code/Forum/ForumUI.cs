#pragma warning disable 0649
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace ForumN
{
    public class ForumUI: MonoBehaviour{
        [SerializeField]
        UIDocument document;

        List<Thread> threads = new List<Thread>();

        void StubThreads(){
            var thread1 = new Thread {
                Title = "Welcome to the Forum!",
                CreatedBy = "Anthrax"
            };
            thread1.Posts.Add(new Post { Content = "Welcome to the forum! Feel free to ask any questions you have about the game here.", Username = "Antrhax", Timestamp = 0 });
            threads.Add(thread1);
            var thread2 = new Thread {
                Title = "The Observatory",
                CreatedBy = "Skyborne"
            };
            thread2.Posts.Add(new Post { Content = "I'm having trouble with the observatory. I can't seem to find the right angle to get the right star.", Username = "Skyborne", Timestamp = 5391382 });
            threads.Add(thread2);
            var thread3 = new Thread {
                Title = "The FBI",
                CreatedBy = "Ananarcz"
            };
            thread3.Posts.Add(new Post { Content = "Anyone else noice a lot more FBI chatter and raids recently? Don't they ahve anythign better to do?", Username = "Ananarcz", Timestamp = 5391382 });
            threads.Add(thread3);
        }
        void AddThreadsToForumUI(){
            var threadsContainer = document.rootVisualElement.Q<VisualElement>("ThreadContainer");
            Debug.Log("threadsContainer: " + threadsContainer);
            Debug.Log(threadsContainer.name);
            foreach(var thread in threads){
                var threadSummaryUI = new ThreadSummaryUI(thread);
                threadsContainer.Add(threadSummaryUI);
            }
            Debug.Log(threadsContainer.name + " " + threadsContainer.childCount);
        }
        void Start(){
            AddThreadsToForumUI();
        }
        void Awake(){
            StubThreads();
        }
    }
}
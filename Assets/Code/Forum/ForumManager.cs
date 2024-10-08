#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ForumN
{
    public class ForumManager : MonoBehaviour
    {
        Dictionary<string, User> users = new Dictionary<string, User>();
        Dictionary<int, List<PostBlockJSON>> unusedPostBlocks = new Dictionary<int, List<PostBlockJSON>>();
        List<Thread> threads = new List<Thread>();
        public static ForumManager T { get; private set; }

        public void AddUser(string name) {
            if (!users.ContainsKey(name))
                users.Add(name, new User());
        }
        public void AddThread(Thread thread) {
            threads.Add(thread);
        }
        public User GetUser(string username){
            if(!users.ContainsKey(username))
                return new User(){
                    Username = $"[NON-EXISTENT USER] {username}"
                };
            return users[username];
        }
        public void SortThreads() {
            threads.Sort((a, b) => b.Posts[^1].Timestamp - a.Posts[^1].Timestamp);
        }   
        public void IngestPostBlock(PostBlockJSON block) {
            if (!unusedPostBlocks.ContainsKey(block.priority))
                unusedPostBlocks.Add(block.priority, new List<PostBlockJSON>());
            unusedPostBlocks[block.priority].Add(block);
        }
        public void RemovePostBlock(PostBlockJSON block) {
            if (unusedPostBlocks.ContainsKey(block.priority))
                unusedPostBlocks[block.priority].Remove(block);
        }
        public void AddBlockToThread(PostBlockJSON postBlock){
            var thread = threads.Find(t => t.Title == postBlock.threadtitle);
            if(thread == null){
                thread = new Thread();
                AddThread(thread);
                thread.Title = postBlock.threadtitle;
            }
            foreach(var post in postBlock.posts){
                var newPost = new Post {
                    Content = post.content,
                    Username = post.username,
                    Timestamp = post.timestamp
                };
                thread.Posts.Add(newPost);
                thread.ContainedPostIDs.Add(postBlock.id);
            }
        }
        void Awake(){
            if(T == null){
                T = this;
            } else {
                Destroy(gameObject);
                return;
            }
        }
    }
}
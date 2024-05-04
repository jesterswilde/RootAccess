#pragma warning disable 0649
using UnityEngine;

namespace ForumN
{
    public class Post {
        [SerializeField]
        string content; 
        public string Content {get => content; set => content = value;}
        [SerializeField]
        string username;
        public string Username {get => username; set => username = value;}
        [SerializeField]
        int timestamp;
        public int Timestamp {get => timestamp; set => timestamp = value;}
        public string GetTime() {
            return new System.DateTime(1970, 1, 1, 0, 0, 0, System.DateTimeKind.Utc).AddSeconds(timestamp).ToLocalTime().ToString();
        }
    }
}
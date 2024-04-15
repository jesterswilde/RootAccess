#pragma warning disable 0649
using UnityEngine;

namespace ForumN
{
    public class User { 
        [SerializeField]
        string _username;
        public string Username {get => _username; set => _username = value;}
        [SerializeField]
        string _tagline;
        public string Tagline {get => _tagline; set => _tagline = value;}
        string _createdAt;
        public string CreatedAt {get => _createdAt; set => _createdAt = value;}
        int _posts = 0;
        public int Posts {get => _posts; set => _posts = value;}
        string _role;
        public string Role {get => _role; set => _role = value;}
        string _avatarURL;
        public string AvatarURL {get => _avatarURL; set => _avatarURL = value;}
    }
}
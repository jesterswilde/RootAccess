#pragma warning disable 0649
using UnityEngine;

namespace ForumN
{
    public class User { 
        [SerializeField]
        string username;
        public string Username => username;
        [SerializeField]
        string tagline;
        public string Tagline => tagline;
    }
}
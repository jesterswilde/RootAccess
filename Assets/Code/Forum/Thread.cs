#pragma warning disable 0649
using System.Collections.Generic;
using UnityEngine;

namespace ForumN
{
    public class Thread { 
        [SerializeField]
        string title;
        public string Title {get => title; set => title = value;}
        [SerializeField]
        string createdBy;
        public string CreatedBy {get => createdBy; set => createdBy = value;}
        [SerializeField]
        List<Post> posts = new List<Post>();
        public List<Post> Posts => posts;
        public List<string> ContainedPostIDs = new List<string>();
    }
}
#pragma warning disable 0649
using System;
using UnityEngine.UIElements;

namespace ForumN
{
    public class Navigation
    {
        public event Action<Navigation> OnPageChange;
        Page _currentPage = Page.ForumHome;
        public Page CurrentPage { get => Page.ForumHome; set {
            if(value != _currentPage){
                _currentPage = value;
                OnPageChange?.Invoke(this);
            }
        }}
        public Thread CurrentThread { get; internal set; }

        internal void GoToThread(Thread thread)
        {
            CurrentThread = thread;
            OnPageChange?.Invoke(this);
        }
        public enum Page
        {
            ForumHome,
            Thread
        }
    }
}
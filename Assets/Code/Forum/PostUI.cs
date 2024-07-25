#pragma warning disable 0649
using UnityEngine;
using UnityEngine.UIElements;

namespace ForumN
{
    public class PostUI : VisualElement {
        string PrintTagline(string tagline){
            if(tagline == null || tagline == ""){
                return "";
            }
            return $"\n---------------------------\n<i>{tagline}</i>";
        }
        public PostUI(int postIndex, Thread thread) {
            var post = thread.Posts[postIndex];
            AddToClassList("post");
            var row1 = new VisualElement();
            var username = new Label(post.Username);
            username.AddToClassList("col-1");
            var postHeading = new Label($"Subject: {thread.Title} | Post #{postIndex} | {post.GetTime()}");
            postHeading.AddToClassList("col-2");
            row1.Add(username);
            row1.Add(postHeading);

            var row2 = new VisualElement();
            var user = ForumManager.T.GetUser(post.Username);
            var userDetails = new VisualElement();
            userDetails.AddToClassList("col-1");
            userDetails.AddToClassList("userDetails");
            if(user.AvatarURL != null && user.AvatarURL != ""){
                var avatar = new Image();
                avatar.AddToClassList("avatar");
                avatar.image = Resources.Load<Texture2D>(user.AvatarURL); // MOVE ELSEWHERE
                userDetails.Add(avatar);
            }
            var role = new Label($"<b>Roole: </b>{user.Role}");
            userDetails.Add(role);
            var content = new Label($"{post.Content}{PrintTagline(user.Tagline)}");
            row2.Add(userDetails);
            row2.Add(content);
        }
    }
}
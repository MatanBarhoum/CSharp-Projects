using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackOverrFlowPost
{
    public class Post
    {
        public string title;
        public string date = DateTime.Now.ToString();
        public int postID;
        public string postBody;

        public void CreatePost()
        {
            Console.Write("Post name: ");
            title = Console.ReadLine();
            Console.Write("Write a message: ");
            postBody = Console.ReadLine();
            this.postID = ++postID;
            Console.WriteLine("Post created. Your Post ID: {0}\n", postID);
            var addpost = new PostByID();
            addpost.AddPost(this.postID, title, postBody, 0);
        }

        public void ShowPostByID()
        {
            var showpost = new PostByID();
            Console.Write("\nPost ID: ");
            var result = Console.ReadLine();
            if (string.IsNullOrEmpty(result)) { Console.WriteLine("Error. numbers only."); }
            else
            {
                showpost.GetPostByID(Convert.ToInt32(result));
            }
        }

    }
}

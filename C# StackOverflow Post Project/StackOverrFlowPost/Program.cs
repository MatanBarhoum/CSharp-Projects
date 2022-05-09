using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackOverrFlowPost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var postsID = new List<int>();
            Post post = new Post();
            while (true)
            {
                Console.WriteLine("Created by Matan Barhoum\n");
                Console.Write("Choose action (post, show, remove): ");
                var answer = Console.ReadLine().ToLower();
                if (answer == "post")
                {
                    post.CreatePost();
                }

                else if (answer == "show")
                {
                    post.ShowPostByID();
                }

            }
        }
    }
}

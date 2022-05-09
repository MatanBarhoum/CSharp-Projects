using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackOverrFlowPost
{
    public class PostByID
    {
        public static List<int> PostID = new List<int>();
        public static List<string> PostTitle = new List<string>();
        public static List<string> PostBody = new List<string>();
        public static List<int> PostVotes = new List<int>();
        public void AddPost(int postID, string postTitle, string postBody, int Votes)
        {
            PostID.Add(postID);
            PostTitle.Add(postTitle);
            PostBody.Add(postBody);
            PostVotes.Add(Votes);
        }

        public void GetPostByID(int ID)
        {
            if (ID == 0) { Console.WriteLine("Error, there's no posts."); }
            else
            {
                string date = DateTime.Now.ToString();
                Console.WriteLine("\nPost ID: {0}", PostID[ID - 1]);
                Console.WriteLine("Title: {0}", PostTitle[ID - 1]);
                Console.WriteLine("Message: {0}", PostBody[ID - 1]);
                Console.WriteLine("Votes: {0}", PostVotes[ID - 1]);
                Console.WriteLine("Created at: {0}\n", date);

                Console.WriteLine("upvote, downvote or exit? ");
                var answer = Console.ReadLine().ToLower();
                if (answer == "upvote" ) { UpVote(ID); Console.WriteLine("Your upvote registered.\n"); }
                else if (answer == "downvote") { DownVote(ID); Console.WriteLine("Your downvote registered.\n"); }
                else { Console.WriteLine("Taking you back home...\n"); }
            }
        }

        public void UpVote(int ID) 
        {
            PostVotes[ID - 1] += 1;
        }

        public void DownVote(int ID)
        {
            PostVotes[ID - 1] -= 1;
        }
    }
}

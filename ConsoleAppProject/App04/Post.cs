using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    public class Post
    {
        public int PostID { get; }

        public String Username { get; }

        public DateTime Time { get; }

        private readonly List<String> comments;

        private static int instances = 0;

        private int likes;

        

        public Post(string author)
        {
            instances++;
            PostID = instances;

            this.Username = author;
            Time = DateTime.Now;

            likes = 0;

            comments = new List<String>();

        }

        /// <summary>
        /// Method that adds a like to the post when user has liked.
        /// </summary>

        public void Like()
        {
            likes++;
        }

        /// <summary>
        /// Method that decreases the like count by one when someone
        /// unlikes.
        /// </summary>

        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        ///<summary>
        /// Method for adding a comment by the user.
        /// </summary>

        public void AddComments(String comment)
        {
            comments.Add(comment);
        }

        ///<sumamry>
        ///Method used to describe how long ago the post was made.
        ///For example "10 minutes ago". 
        /// </sumamry>

        public String FormatTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - Time;

            long sec = (long)timePast.TotalSeconds;
            long min = sec / 60;

            if (min > 0)
            {
                return min + " min ago.";
            }
            else
            {
                return sec + " sec ago.";
            }
        }

        ///<summary>
        /// Method to print out the post and its details.
        /// </summary>

        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($" PostID: {PostID}");
            Console.WriteLine($" Username: {Username}");
            Console.WriteLine($" Time: {FormatTime(Time)}");
            Console.WriteLine();
            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"    Likes:  {likes}  people have liked this post.");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments have been made!");
            }
            else
            {
                Console.WriteLine($"    {comments.Count}  comment(s). Click here to load all the comments.");
            }
        }

        public static int GetNumberOfPosts()
        {
            return instances;
        }
    }
}
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


    }

}
using System;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// This class offers a console based user interface for the
    /// NewsFeed class and allows users to make multiple posts
    /// 
    /// Author: Galimir Bozmarov
    /// </summary>
    public class NetworkApp
    {
        private readonly NewsFeed news = new NewsFeed();

        public NewsFeed NewsFeed
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Prints out the menu for the app.
        /// </summary>
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("Galimir's News Feed");

            string[] choices = new string[]
            {
                "Post Message", "Post Image",
                "Remove Post", "Display All Posts",
                "Display Posts by Username", "Display Posts by Date",
                "Add Comments to the Post",  "Like a Post", "Unlike a post",
                "Quit"
            };

            bool Quit = false;

            do
            {
                int choice = ConsoleHelper.MakeChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: RemovePost(); break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayByAuthor(); break;
                    case 6: DisplayByDate(); break;
                    case 7: AddComment(); break;
                    case 8: LikePosts(); break;
                    case 9: UnlikeLikePosts(); break;
                    case 10: Quit = true; break;
                }

            } while (!Quit);
        }


        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// Method to remove a post.
        /// </summary>
        
        private void RemovePost()
        {
            ConsoleHelper.OutputTitle("Remove a Post");

            int id = (int)ConsoleHelper.InputNumber("Please enter the post id: ",
                                                    1, Post.GetNumberOfPosts());
            news.RemovePost(id);
        }

        /// <summary>
        /// Method to post an image.
        /// </summary>
        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Posting an Image/Photo");

            string author = InputName();

            Console.Write("Please enter the filename of the image: ");

            string filename = Console.ReadLine();

            Console.Write("Please enter a caption for the image: ");

            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("You have just posted this image: ");
            post.Display();
        }

        /// <summary>
        /// Method to input the name.
        /// </summary>
        private string InputName()
        {
            Console.Write("Please enter your name: ");
            string author = Console.ReadLine();

            return author;
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting a Message");

            string author = InputName();

            Console.Write("Please enter a message: ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle("You have just posted this message: ");
            post.Display();
        }

        public Post FindPost()
        {
            int postID;
            postID = (int)ConsoleHelper.InputNumber("Please enter the ID of the post: ");
            return news.FindPost(postID);
        }

        private void LikePosts()
        {
            Console.WriteLine("Like a Post");
            Post post = FindPost();

            post.Like();
        }

        private void UnlikeLikePosts()
        {
            Console.WriteLine("Unlike a Post");
            Post post = FindPost();

            post.Unlike();
        }


        private void AddComment()
        {
            Console.WriteLine("Add a comment to a Post");
            Post post = FindPost();
            post.Display();
            Console.WriteLine("Please enter your comment!");
            string comment = Console.ReadLine();
            post.AddComments(comment);
        }

        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }

        private void DisplayByAuthor()
        {
            Console.WriteLine("Which users posts would you like to find ");
            string author = Console.ReadLine();

            news.FindPostByUser(author);

        }

    }
}
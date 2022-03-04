using System;

namespace SocialMediaInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post();
            Console.WriteLine(post.ToString());
            Post post2 = new Post("Left-Wing", true, "Chris Fragulis");
            Console.WriteLine(post2.ToString());
        }
    }
}

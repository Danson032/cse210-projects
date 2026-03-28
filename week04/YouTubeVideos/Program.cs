using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Learn C# Basics", "Code Academy", 600);
        v1.AddComment(new Comment("Alex", "Very helpful!"));
        v1.AddComment(new Comment("Mia", "I finally understand classes."));
        v1.AddComment(new Comment("John", "Great explanation."));

        Video v2 = new Video("Gaming Highlights", "ProGamer", 420);
        v2.AddComment(new Comment("Sam", "Awesome gameplay!"));
        v2.AddComment(new Comment("Chris", "So cool!"));
        v2.AddComment(new Comment("Taylor", "Nice skills"));

        Video v3 = new Video("Cooking Pasta", "Chef Mike", 300);
        v3.AddComment(new Comment("Emma", "Looks delicious!"));
        v3.AddComment(new Comment("Noah", "I will try this."));
        v3.AddComment(new Comment("Liam", "Simple and clear instructions."));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.Display();
        }
    }
}
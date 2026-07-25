using System;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video programming = new Video("Programming with Python", "Mosh Hamadan",1856);

        programming.AddComment(new Comment("Rudo", "Quite informative!"));
        programming.AddComment(new Comment("Chipo", "Great stuff!"));
        programming.AddComment(new Comment("Ranga", "Brilliant!"));
        programming.AddComment(new Comment("Shamie", "Good work!"));
        videos.Add(programming);

        Video biology = new Video("Learning Biology", "Petronella Zee", 1665);

        biology.AddComment(new Comment("Kim", "Very informative!"));
        biology.AddComment(new Comment("Ruth", "A bit confusing!"));
        biology.AddComment(new Comment("Tendai", "Well done!"));
        biology.AddComment(new Comment("Pardon", "Incredible work!"));
        videos.Add(biology);

        Video chemistry = new Video("Chemistry Explained","Dr Brutus",1864);

        chemistry.AddComment(new Comment("Cathbert", "Amazing stuff!"));
        chemistry.AddComment(new Comment("Kina", "Well explained!"));
        chemistry.AddComment(new Comment("Kobby", "Not sure I follow!"));
        chemistry.AddComment(new Comment("Nolan", "I am a bit confused!"));
        videos.Add(chemistry);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title   : {video._title}");
            Console.WriteLine($"Author  : {video._author}");
            Console.WriteLine($"Length  : {video._length} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");
            Console.WriteLine();

            Console.WriteLine("Comment List:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment._commenter}- {comment._commentText}");
            }

            Console.WriteLine();
        }
    }
}
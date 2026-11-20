using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video
        {
            _title = "How to Make Bread",
            _author = "Baker Sam",
            _length = 600
        };
        Comment comment1 = new Comment
        {
            _name = "Alice",
            _text = "Great video! I learned a lot."
        };
        video1._comments.Add(comment1);
        Comment comment2 = new Comment
        {
            _name = "Bob",
            _text = "I tried this recipe, it worked!"
        };
        video1._comments.Add(comment2);
        Comment comment3 = new Comment
        {
            _name = "Luke",
            _text = "Man, this bread was so delicious! I will make it again."
        };
        video1._comments.Add(comment3);
        Comment comment4 = new Comment
        {
            _name = "Charlie",
            _text = "I had some trouble with the dough, but it turned out okay."
        };
        video1._comments.Add(comment4);

        Video video2 = new Video
        {
            _title = "Lightsaber Combat Techniques",
            _author = "Grand Jedi Master Yoda",
            _length = 800
        };
        Comment comment5 = new Comment
        {
            _name = "Rey",
            _text = "Now this is the ways of the Jedi!"
        };
        video2._comments.Add(comment5);
        Comment comment6 = new Comment
        {
            _name = "Kylo Ren",
            _text = "I will destroy the Jedi!"
        };
        video2._comments.Add(comment6);
        Comment comment7 = new Comment
        {
            _name = "Obi-Wan Kenobi",
            _text = "The Force will be with you, always."
        };
        video2._comments.Add(comment7);
        Comment comment8 = new Comment
        {
            _name = "Mace Windu",
            _text = "This is a great tutorial for aspiring Jedi."
        };
        video2._comments.Add(comment8);

        Video video3 = new Video
        {
            _title = "How to Build a Robot",
            _author = "Droid Engineer R2-D2",
            _length = 1200
        };
        Comment comment9 = new Comment
        {
            _name = "C-3PO",
            _text = "This is a very informative video. Thank you!"

        };
        video3._comments.Add(comment9);
        Comment comment10 = new Comment
        {
            _name = "BB-8",
            _text = "I can't wait to build my own robot!"
        };
        video3._comments.Add(comment10);
        Comment comment11 = new Comment
        {
            _name = "R2-V9",
            _text = "Beep beep boop! This is a great tutorial!"
        };
        video3._comments.Add(comment11);
        Comment comment12 = new Comment
        {
            _name = "Droid Builder",
            _text = "I learned a lot from this video. Thanks!"
        };
        video3._comments.Add(comment12);
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"  {comment._name}: {comment._text}");
            }
            Console.WriteLine();

        }
    }
}
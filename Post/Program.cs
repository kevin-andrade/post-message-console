using Post.Entities;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new("Have a nice trip");
            Comment c2 = new("Wow thats's awesome!");

            PostMessage p1 = new(
                DateTime.Parse("26/09/2023 15:43:10"),
                "Travelling to Brazil",
                "I'm going to visit this wonderful country!",
                5
            );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);

            Comment b1 = new("Good night");
            Comment b2 = new("May the Force be with you");

            PostMessage p2 = new(
                DateTime.Parse("19/05/2023 22:53:10"),
                "Good night guys",
                "See you tomorrow",
                3
            );

            p2.AddComment(b1);
            p2.AddComment(b2);

            Console.WriteLine(p2);
        }
    }
}
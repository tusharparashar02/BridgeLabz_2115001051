using System;


namespace Assignments
{
    // Base class
    class Book
    {
        public string Title { get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, int publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Publication Year: {PublicationYear}");
        }
    }

    // Subclass: Author
    class Author : Book
    {
        public string Name { get; set; }
        public string Bio { get; set; }

        public Author(string title, int publicationYear, string name, string bio) : base(title, publicationYear)
        {
            Name = name;
            Bio = bio;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Publication Year: {PublicationYear}, Author: {Name}, Bio: {Bio}");
        }
    }

    class Class4
    {
        public static void Main4()
        {
            Book book = new Author("Book", 089, "Author", "Harry Potter");
            book.DisplayInfo();
        }
    }
}

using System;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    // Default Constructor
    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Price = 0.0;
    }

    // Parameterized Constructor
    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
}
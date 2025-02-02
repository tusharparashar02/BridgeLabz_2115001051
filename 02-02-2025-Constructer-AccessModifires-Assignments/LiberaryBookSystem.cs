using System;
class LiberaryBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; }

    // Default Constructor
    public Book()
    {
        Title = "Hello GLA";
        Author = "Tushar Parashar";
        Price = 0.0;
        IsAvailable = true;
    }

    // Parameterized Constructor
    public Book(string title, string author, double price, bool isAvailable)
    {
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = isAvailable;
    }

    // Borrow Book Method
    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine(Title +"has been borrowed.");
        }
        else
        {
            Console.WriteLine(Title +"is currently not available.");
        }
    }
}
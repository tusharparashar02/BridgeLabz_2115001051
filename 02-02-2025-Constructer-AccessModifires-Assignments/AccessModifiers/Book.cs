class Book
{
    public string ISBN { get; set; }
    protected string Title { get; set; }
    private string Author;

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    public string GetAuthor()
    {
        return Author;
    }

    public void SetAuthor(string author)
    {
        Author = author;
    }
}

// EBook Class
class EBook : Book
{
    public double FileSize { get; set; }

    public EBook(string isbn, string title, string author, double fileSize)
        : base(isbn, title, author)
    {
        FileSize = fileSize;
    }
}
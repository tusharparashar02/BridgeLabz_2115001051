using System;

class Book
{
    public string Title;
    public string Author;
    public double Price;
    public void DisplayDetails(){
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: " + Price);
    }

    static void Main(string[] args){
        Book book = new Book();
        book.Title = "C# Training by BridgeLabz";
        book.Author = "Capgemini";
        book.Price = 100;
        book.DisplayDetails();
    }
}

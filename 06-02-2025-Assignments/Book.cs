using System;
using System.Collections.Generic;

namespace Assignments
{
    // Book class
    class Book{
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string title, string author){
            Title = title;
            Author = author;
        }

        public void DisplayInfo(){
            Console.WriteLine("Book: " + Title + " by " + Author);
        }
    }

    // Library class (Aggregation with Books)
    class Library{
        public string LibraryName { get; set; }
        public List<Book> Books { get; private set; } = new List<Book>();
        public Library(string libraryName){
            LibraryName = libraryName;
        }
        public void AddBook(Book book){
            Books.Add(book);
        }
        public void ShowBooks(){
            Console.WriteLine("Books in " + LibraryName + ":");
            foreach (var book in Books){
                book.DisplayInfo();
            }
            Console.WriteLine("");
        }
    }

    // Main Program
    class Class1
    {
        public static void Main1(){
            // Create Libraries
            Library library1 = new Library("Library1");
            Library library2 = new Library("Library2");
            // Create Books
            Book book1 = new Book("Book1", "Author1");
            Book book2 = new Book("Book2", "Author2");
            Book book3 = new Book("Book3", "Author3");
            // Add books to libraries (Aggregation)
            library1.AddBook(book1);
            library1.AddBook(book2);
            library2.AddBook(book2);
            library2.AddBook(book3);
            // Display books in each library
            library1.ShowBooks();
            library2.ShowBooks();
        }
    }

}
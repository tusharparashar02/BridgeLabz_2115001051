using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LibraryManagement
    {
        public string Title;
        public string Author;
        public string Genre;
        public int BookID;
        public bool IsAvailable;
        public LibraryManagement Next, Prev;

        public LibraryManagement(string title, string author, string genre, int bookID, bool isAvailable)
        {
            Title = title;
            Author = author;
            Genre = genre;
            BookID = bookID;
            IsAvailable = isAvailable;
        }
    }
    class LibraryLinkedlist {
        private LibraryManagement head;
        private LibraryManagement tail;
        private int count = 0;

        public void AddAtBeginning(string title, string author, string genre, int bookID, bool isAvailable)
        {
            LibraryManagement newBook = new LibraryManagement(title, author, genre, bookID, isAvailable);
            if (head == null)
                head = tail = newBook;
            else
            {
                newBook.Next = head;
                head.Prev = newBook;
                head = newBook;
            }
            count++;
        }

        public void AddAtEnd(string title, string author, string genre, int bookID, bool isAvailable)
        {
            LibraryManagement newBook = new LibraryManagement(title, author, genre, bookID, isAvailable);
            if (head == null)
                head = tail = newBook;
            else
            {
                newBook.Prev = tail;
                tail.Next = newBook;
                tail = newBook;
            }
            count++;
        }

        public void AddAtPosition(string title, string author, string genre, int bookID, bool isAvailable, int position)
        {
            if (position < 1 || position > count + 1)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            if (position == 1)
            {
                AddAtBeginning(title, author, genre, bookID, isAvailable);
                return;
            }

            LibraryManagement newBook = new LibraryManagement(title, author, genre, bookID, isAvailable);
            LibraryManagement temp = head;
            for (int i = 1; i < position - 1; i++)
                temp = temp.Next;

            newBook.Next = temp.Next;
            newBook.Prev = temp;
            if (temp.Next != null)
                temp.Next.Prev = newBook;
            temp.Next = newBook;

            if (newBook.Next == null)
                tail = newBook;

            count++;
        }

        public void RemoveBook(int bookID)
        {
            if (head == null)
            {
                Console.WriteLine("No books in the library.");
                return;
            }

            LibraryManagement temp = head;
            while (temp.Next != null)
            {
                count++;
                if (temp.Next.BookID == bookID)
                {
                    temp.Next.Next.Prev = temp;
                    temp.Next = temp.Next.Next;

                    Console.WriteLine("Book removed ");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Book not found");
        }

        public void SearchBookByTitle(string title)
        {
            LibraryManagement temp = head;
            while (temp != null)
            {
                if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Found: {temp.Title} by {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Book not found.");
        }

        public void SearchBookByAuthor(string author)
        {
            LibraryManagement temp = head;
            while (temp != null)
            {
                if (temp.Author == author)
                {
                    Console.WriteLine($"Found: {temp.Title} by {temp.Author}");
                }
                temp = temp.Next;
            }
        }

        public void UpdateAvailability(int bookID, bool newStatus)
        {
            LibraryManagement temp = head;
            while (temp != null)
            {
                if (temp.BookID == bookID)
                {
                    temp.IsAvailable = newStatus;
                    Console.WriteLine("Availability updated.");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Book not found.");
        }

        public void DisplayForward()
        {
            LibraryManagement temp = head;
            while (temp != null)
            {
                Console.WriteLine($"{temp.Title}->");
                temp = temp.Next;
            }
            Console.WriteLine();
            Console.WriteLine("------------");
        }

        public void DisplayReverse()
        {
            LibraryManagement temp = tail;
            while (temp != null)
            {
                Console.Write($"{temp.Title}<-");
                temp = temp.Prev;
            }
            Console.WriteLine();
            Console.WriteLine("-------------");
        }

        public void CountBooks()
        {
            Console.WriteLine($"Total number of books: {count}");
        }

        public static void Main5()
        {
            LibraryLinkedlist lib = new LibraryLinkedlist();

            lib.AddAtBeginning("Book1", "Author1", "English", 1001, true);
            lib.AddAtEnd("Book2", "Author2", "Physics", 1002, false);
            lib.AddAtPosition("Book3", "Author3", "chemistry", 1003, true, 1);

            Console.WriteLine("Library (Forward):");
            lib.DisplayForward();

            Console.WriteLine("Library (Reverse):");
            lib.DisplayReverse();

            lib.RemoveBook(102);
            lib.DisplayForward();

            lib.SearchBookByTitle("Book1");
            lib.SearchBookByAuthor("Author3");

            lib.UpdateAvailability(103, false);
            lib.DisplayReverse();

            lib.CountBooks();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class MovieManagement
    {
        public string title;
        public string director;
        public int year;
        public double rating;

        public MovieManagement next, prev;

        public MovieManagement(string title, string director, int year, double rating)
        {
            this.title = title;
            this.director = director;
            this.year = year;
            this.rating = rating;
        }
    }
    public class MovieLinkedList
    {
        private MovieManagement head;
        private MovieManagement tail;

        public void AddAtBegining(string title, string director, int year, double rating)
        {
            MovieManagement newMovie = new MovieManagement(title, director, year, rating);
            if (head == null)
                head = tail = newMovie;
            else
            {
                newMovie.next = head;
                head.prev = newMovie;
                head = newMovie;
            }
        }

        public void AddInEnd(string title, string director, int year, double rating)
        {
            MovieManagement newMovie = new MovieManagement(title, director, year, rating);
            if (head == null)
                head = tail = newMovie;
            else
            {
                newMovie.prev = tail;
                tail.next = newMovie;
                tail = newMovie;
            }
        }

        public void AddAtGivenPosition(string title, string director, int year, double rating, int position)
        {
            MovieManagement newMovie = new MovieManagement(title, director, year, rating);
            MovieManagement temp = head;
            MovieManagement tmp = head;

            int len = 0;
            while (temp != null)
            {
                len++;
                temp = temp.next;
            }

            if (position > len + 1 || position < 0)
                Console.WriteLine("Enter valid position");
            else
            {
                if (position == 1)
                    AddAtBegining(title, director, year, rating);

                position--;
                while (position > 1)
                {
                    tmp = tmp.next;
                    position--;
                }
                newMovie.prev = tmp;
                newMovie.next = tmp.next;
                tmp.next.prev = newMovie;
                tmp.next = newMovie;
            }
            
        }

        public void DeleteMovie(string title)
        {
            if (head == null)
            {
                Console.WriteLine("no movie found");
                return ;
            }

            MovieManagement temp = head;
            int count = 0;
            while (temp.next != null)
            {
                count++;
                if (temp.next.title == title)
                {
                    temp.next.next.prev = temp;
                    temp.next = temp.next.next;

                    Console.WriteLine("movie deleted ");
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Movie not found");

            
        }

        public void SearchMovieByDirector(string director)
        {
            MovieManagement temp = head;
            while (temp != null)
            {
                if (temp.director == director)
                {
                    Console.WriteLine($"{temp.title} found");
                    return ;
                }
                temp = temp.next;
            }
            Console.WriteLine("Movie not available");
            
        }

        public void SearchMovieByRating(double rating)
        {
            MovieManagement temp = head;
            while (temp != null)
            {
                if (temp.rating == rating)
                {
                    Console.WriteLine($"{temp.title} found");
                    return ;
                }
                temp = temp.next;
            }
            Console.WriteLine("Movie not available");
            
        }

        public void UpdateMovieRating(string title, double newRating)
        {
            MovieManagement temp = head;
            while (temp != null)
            {
                if (temp.title == title)
                {
                    temp.rating = newRating;
                    Console.WriteLine("Rating updated");
                    return ;
                }
                temp = temp.next;
            }
           
        }

        public void DisplayForward()
        {
            MovieManagement temp = head;
            while (temp != null)
            {
                Console.Write($"{temp.title}->");
                temp = temp.next;
            }
            Console.WriteLine();
            Console.WriteLine("....................");
        }

        public void DisplayReverse()
        {
            MovieManagement temp = tail;
            while (temp != null)
            {
                Console.Write($"{temp.title}<-");
                temp = temp.prev;
            }
            Console.WriteLine();
            Console.WriteLine(".......................");
        }

        public static void Main2()
        {
            MovieLinkedList obj = new MovieLinkedList();

            obj.AddAtBegining("Movie2", "Director2", 2017, 5.2);
            obj.AddAtBegining("Movie1", "Director1", 2020, 8.4);

            obj.AddInEnd("Movie3", "Director3", 2006, 4.4);
            obj.AddAtGivenPosition("Movie4", "Director4", 2000, 6.4, 3);

            Console.WriteLine("Movie List (Forward):");
            obj.DisplayForward();

            Console.WriteLine("Movie List (Reverse):");
            obj.DisplayReverse();

            obj.DeleteMovie("Movie2");
            obj.DisplayForward();

            obj.SearchMovieByDirector("Director2");

            obj.UpdateMovieRating("Movie1", 6.0);
            obj.DisplayReverse();
        }

    }
}

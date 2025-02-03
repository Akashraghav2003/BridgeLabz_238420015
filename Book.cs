using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Book
    {
        public string ISBN;
        protected string Title;
        private string Author;

        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        // Method to get the author name
        public string GetAuthor()
        {
            return Author;
        }

        // Method to set the author name
        public void SetAuthor(string author)
        {
            Author = author;
        }
    }

    // Subclass EBook
    public class EBook : Book
    {
        public EBook(string isbn, string title, string author)
            : base(isbn, title, author) { }

        public void DisplayBookInfo()
        {
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + GetAuthor()); // Accessing private member using getter
        }

        public static void Main(string[] args)
        {
            EBook ebook = new EBook("123", "C# Programming", "raghav");
            ebook.DisplayBookInfo();

            // Modifying author name using setter
            ebook.SetAuthor("Jane Smith");
            Console.WriteLine("Updated Author: " + ebook.GetAuthor());
        }
    }
}

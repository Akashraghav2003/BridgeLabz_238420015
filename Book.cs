//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPs_second
//{
//    internal class Book
//    {
//        // Static variable to store library name, shared across all instances
//        private static string libraryName = "Central Library";

//        // Instance variables to store book details
//        private string title;
//        private string author;

//        // Readonly variable to ensure ISBN cannot be changed once assigned
//        private readonly int isbn;

//        // Parameterized constructor to initialize book title and author
//        public Book(string title, string author)
//        {
//            this.title = title;
//            this.author = author;
//            Random random = new Random();
//            this.isbn = random.Next(10000, 99999); // Generating a random ISBN number
//        }

//        // Default constructor to initialize ISBN only
//        public Book()
//        {
//            Random random = new Random();
//            this.isbn = random.Next(10000, 99999);
//        }

//        // Method to set book details manually
//        public void SetDetails()
//        {
//            Console.WriteLine("Enter the Title of book: ");
//            title = Console.ReadLine();
//            Console.WriteLine("Enter the book author: ");
//            author = Console.ReadLine();
//        }

//        // Private method to display book details
//        private void DisplayDetails()
//        {
//            if (this is Book) // Checking if the object is an instance of Book class
//            {
//                Console.WriteLine($"Title of Book: {title}, Author of Book: {author}, ISBN: {isbn}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid book instance");
//            }
//        }

//        // Public method to access the private display method
//        public void GetDisplayDetails()
//        {
//            DisplayDetails();
//        }

//        // Private static method to display library name
//        private static void DisplayLibraryName()
//        {
//            Console.WriteLine($"Library name: {libraryName}");
//        }

//        // Public method to access the static library name display method
//        public void GetDisplayLibraryName()
//        {
//            DisplayLibraryName();
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Creating a book object and setting details via user input
//            Book book1 = new Book();
//            book1.SetDetails();

//            // Creating another book object with predefined values
//            Book book2 = new Book("The Great Gatsby", "F. Scott Fitzgerald");

//            // Displaying book details
//            book1.GetDisplayDetails();
//            book2.GetDisplayDetails();

//            // Displaying library name
//            book1.GetDisplayLibraryName();
//        }
//    }
//}
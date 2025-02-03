using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Book
    {
        public string title;
        public string author;
        public double price;

        public Book()
        {
            title = "The death was not painfull";
            author = "Dhirendra singh jafa";
            price = 1079;
        }

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {title}, Author: {author}, Price: {price}");
        }

        public static void Main(String[] args)
        {
            Book book = new Book();
            book.Display();
            Console.WriteLine("Enter the book Title");
            string title = Console.ReadLine();
            Console.WriteLine("write the Author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Write the price of Book: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Book book1 = new Book(title, author, price);
            book1.Display();
        }
    }
}

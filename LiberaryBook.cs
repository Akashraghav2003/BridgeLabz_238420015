using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class LiberaryBook
    {
        public string title { get; set; }
        public string author { get; set; }
        public int availability { get; set; }
        public double price { get; set; }

        public LiberaryBook()
        {
            title = "The death was not painfull";
            author = "Dhirendra";
            availability = 5;
            price = 1040;

        }
        public void BorrowBook(string title)
        {
            if (title == this.title && availability > 0)
            {
                Console.WriteLine("You can borrow the book");
            }
            else
            {
                Console.WriteLine("you can not borrow the book.");
            }
        }

        public static void Main(string[] args)
        {
            LiberaryBook liberaryBook = new LiberaryBook();

            Console.WriteLine("Give the title of book: ");
            string title = Console.ReadLine();

            liberaryBook.BorrowBook(title);

        }
    }
}

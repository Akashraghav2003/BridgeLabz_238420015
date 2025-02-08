using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentWithBookAndAuthor
{
    internal class Author : Book
    {
        public string Name { get; set; }
        public string Bio {  get; set; }

        public Author(string name, string bio, string title, string publicationYear ) : base(title, publicationYear)
        {
            Name = name; 
            Bio = bio;
        }

        public  void DisplayInfo()
        {
            Console.WriteLine($"Book Name {Title}, Publication Year {PublicationYear}, Author {Name}, Bio {Bio}");
        }
    }
}

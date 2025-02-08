using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentWithBookAndAuthor
{
    internal class Book
    {
        public  string Title { get; set; }
        public string PublicationYear { get; set; }

        public Book(string title, string publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }


    }
}

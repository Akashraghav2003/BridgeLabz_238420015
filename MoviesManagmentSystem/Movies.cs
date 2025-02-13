using System;

namespace MoviesManagmentSystem
{
    internal class Movies
    {
        public string MoviesTitle { get; set; }
        public string Director { get; set; }
        public DateTime YearOfRelease { get; set; }
        public string Rating { get; set; }
        public Movies Next { get; set; }
        public Movies Prev { get; set; }

        public Movies(string moviesTitle, string director, DateTime yearOfRelease, string rating)
        {
            MoviesTitle = moviesTitle;
            Director = director;
            YearOfRelease = yearOfRelease;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }
}

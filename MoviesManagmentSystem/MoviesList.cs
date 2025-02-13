using System;

namespace MoviesManagmentSystem
{
    internal class MoviesList
    {
        private Movies head;

        public void GetDetails(out string title, out string director, out DateTime yearOfRelease, out string rating)
        {
            Console.WriteLine("Enter the Title:");
            title = Console.ReadLine();

            Console.WriteLine("Enter the Director:");
            director = Console.ReadLine();

            Console.WriteLine("Enter the Date of Release (dd/MM/yyyy):");
            while (!DateTime.TryParse(Console.ReadLine(), out yearOfRelease))
            {
                Console.WriteLine("Invalid date format. Please enter in dd/MM/yyyy format:");
            }

            Console.WriteLine("Enter the Rating:");
            rating = Console.ReadLine();
        }

        public void InsertAtBeginning()
        {
            GetDetails(out string title, out string director, out DateTime yearOfRelease, out string rating);
            Movies newMovie = new Movies(title, director, yearOfRelease, rating);

            if (head != null)
            {
                newMovie.Next = head;
                head.Prev = newMovie;
            }

            head = newMovie;
        }

        public void InsertAtEnd()
        {
            GetDetails(out string title, out string director, out DateTime yearOfRelease, out string rating);
            Movies newMovie = new Movies(title, director, yearOfRelease, rating);

            if (head == null)
            {
                head = newMovie;
                return;
            }

            Movies temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newMovie;
            newMovie.Prev = temp;
        }

        public void InsertSpecificPosition()
        {
            Console.WriteLine("Enter the position:");
            int position;
            while (!int.TryParse(Console.ReadLine(), out position) || position < 1)
            {
                Console.WriteLine("Invalid position. Please enter a positive integer:");
            }

            GetDetails(out string title, out string director, out DateTime yearOfRelease, out string rating);
            Movies newMovie = new Movies(title, director, yearOfRelease, rating);

            if (position == 1)
            {
                InsertAtBeginning();
                return;
            }

            Movies temp = head;
            for (int i = 1; temp != null && i < position - 1; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid position!");
                return;
            }

            newMovie.Next = temp.Next;
            newMovie.Prev = temp;

            if (temp.Next != null)
            {
                temp.Next.Prev = newMovie;
            }

            temp.Next = newMovie;
        }

        public void RemoveMovies()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty!");
                return;
            }

            Console.WriteLine("Enter the Movie Title to Remove:");
            string title = Console.ReadLine();

            Movies temp = head;

            while (temp != null && temp.MoviesTitle != title)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Movie not found!");
                return;
            }

            if (temp.Prev != null)
            {
                temp.Prev.Next = temp.Next;
            }
            else
            {
                head = temp.Next;
            }

            if (temp.Next != null)
            {
                temp.Next.Prev = temp.Prev;
            }

            Console.WriteLine("Movie removed successfully!");
        }

        public void Search()
        {
            Console.WriteLine("To Search Movies by Director Enter 'D', or by Rating Enter 'R':");
            char choice = char.ToUpper(Console.ReadLine()[0]);

            Console.WriteLine(choice == 'D' ? "Enter Director Name:" : "Enter Rating:");
            string searchInput = Console.ReadLine();

            Movies temp = head;
            bool found = false;

            while (temp != null)
            {
                if ((choice == 'D' && temp.Director.Equals(searchInput, StringComparison.OrdinalIgnoreCase)) ||
                    (choice == 'R' && temp.Rating.Equals(searchInput, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"Movie: {temp.MoviesTitle}, Director: {temp.Director}, Year: {temp.YearOfRelease:yyyy}, Rating: {temp.Rating}");
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
            {
                Console.WriteLine("No matching movies found!");
            }
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            Console.WriteLine("\nMovies List (Forward Order):");
            Movies temp = head;
            Movies last = null;

            while (temp != null)
            {
                Console.WriteLine($"Movie: {temp.MoviesTitle}, Director: {temp.Director}, Year: {temp.YearOfRelease:yyyy}, Rating: {temp.Rating}");
                last = temp;
                temp = temp.Next;
            }

            Console.WriteLine("\nMovies List (Reverse Order):");
            while (last != null)
            {
                Console.WriteLine($"Movie: {last.MoviesTitle}, Director: {last.Director}, Year: {last.YearOfRelease:yyyy}, Rating: {last.Rating}");
                last = last.Prev;
            }
        }

        public void UpdateRating()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            Console.WriteLine("Enter the Movie Title to Update Rating:");
            string title = Console.ReadLine();

            Movies temp = head;
            while (temp != null && temp.MoviesTitle != title)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Movie not found!");
                return;
            }

            Console.WriteLine("Enter New Rating:");
            temp.Rating = Console.ReadLine();

            Console.WriteLine("Rating Updated Successfully!");
        }

        public void SwitchCase()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Movie at Beginning\n2. Add Movie at End\n3. Add Movie at Specific Position\n4. Delete a Movie\n5. Search a Movie\n6. Display All Movies\n7. Update Movie Rating\n8. Exit");
                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out int operation) || operation < 1 || operation > 8)
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 8.");
                    continue;
                }

                switch (operation)
                {
                    case 1: InsertAtBeginning(); break;
                    case 2: InsertAtEnd(); break;
                    case 3: InsertSpecificPosition(); break;
                    case 4: RemoveMovies(); break;
                    case 5: Search(); break;
                    case 6: Display(); break;
                    case 7: UpdateRating(); break;
                    case 8: return;
                }
            }
        }
    }
}

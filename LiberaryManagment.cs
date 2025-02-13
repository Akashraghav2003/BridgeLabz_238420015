using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int BookID { get; set; }
    public bool IsAvailable { get; set; }
    public Book Next { get; set; }
    public Book Prev { get; set; }

    public Book(string title, string author, string genre, int bookID, bool isAvailable)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookID = bookID;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}

class Library
{
    private Book head;

    // Add a new book at a specified position
    public void AddBook(string title, string author, string genre, int bookID, bool isAvailable, int position = -1)
    {
        Book newBook = new Book(title, author, genre, bookID, isAvailable);

        if (position == 1 || head == null)
        {
            if (head != null) head.Prev = newBook;
            newBook.Next = head;
            head = newBook;
            return;
        }

        Book temp = head;
        for (int i = 1; temp.Next != null && i < position - 1; i++)
            temp = temp.Next;

        newBook.Next = temp.Next;
        newBook.Prev = temp;

        if (temp.Next != null) temp.Next.Prev = newBook;
        temp.Next = newBook;
    }

    // Remove a book by ID
    public void RemoveBook(int bookID)
    {
        Book temp = head;
        while (temp != null && temp.BookID != bookID)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (temp.Prev != null) temp.Prev.Next = temp.Next;
        else head = temp.Next;

        if (temp.Next != null) temp.Next.Prev = temp.Prev;

        Console.WriteLine($"Book {bookID} removed successfully.");
    }

    // Search for a book by title or author
    public void SearchBook(string searchInput)
    {
        Book temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Title.Equals(searchInput, StringComparison.OrdinalIgnoreCase) ||
                temp.Author.Equals(searchInput, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Book ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {(temp.IsAvailable ? "Yes" : "No")}");
                found = true;
            }
            temp = temp.Next;
        }

        if (!found) Console.WriteLine("No matching books found.");
    }

    // Update availability status of a book
    public void UpdateAvailability(int bookID, bool status)
    {
        Book temp = head;
        while (temp != null && temp.BookID != bookID)
            temp = temp.Next;

        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        temp.IsAvailable = status;
        Console.WriteLine($"Availability status of Book {bookID} updated.");
    }

    // Display all books
    public void DisplayBooks()
    {
        if (head == null)
        {
            Console.WriteLine("No books available.");
            return;
        }

        Console.WriteLine("\nBooks in Library:");
        Book temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Book ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {(temp.IsAvailable ? "Yes" : "No")}");
            temp = temp.Next;
        }
    }

    // Count total books in the library
    public int CountBooks()
    {
        int count = 0;
        Book temp = head;

        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }

        return count;
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();
        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. Update Availability");
            Console.WriteLine("5. Display Books");
            Console.WriteLine("6. Count Books");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Book Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter Genre: ");
                    string genre = Console.ReadLine();
                    Console.Write("Enter Book ID: ");
                    int bookID = int.Parse(Console.ReadLine());
                    Console.Write("Is Available (true/false): ");
                    bool isAvailable = bool.Parse(Console.ReadLine());
                    Console.Write("Enter Position (or -1 for end): ");
                    int position = int.Parse(Console.ReadLine());

                    library.AddBook(title, author, genre, bookID, isAvailable, position);
                    break;

                case 2:
                    Console.Write("Enter Book ID to remove: ");
                    int removeID = int.Parse(Console.ReadLine());
                    library.RemoveBook(removeID);
                    break;

                case 3:
                    Console.Write("Enter Book Title or Author to search: ");
                    string search = Console.ReadLine();
                    library.SearchBook(search);
                    break;

                case 4:
                    Console.Write("Enter Book ID to update: ");
                    int updateID = int.Parse(Console.ReadLine());
                    Console.Write("Is Available (true/false): ");
                    bool status = bool.Parse(Console.ReadLine());
                    library.UpdateAvailability(updateID, status);
                    break;

                case 5:
                    library.DisplayBooks();
                    break;

                case 6:
                    Console.WriteLine($"Total books: {library.CountBooks()}");
                    break;

                case 7:
                    return;

                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }
        }
    }
}
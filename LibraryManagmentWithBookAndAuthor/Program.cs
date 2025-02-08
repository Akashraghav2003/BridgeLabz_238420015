using LibraryManagmentWithBookAndAuthor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Title of book ");
        string title = Console.ReadLine();

        Console.WriteLine("Enter the Publication Year");
        string publicationYaer = Console.ReadLine();

        Console.WriteLine("Enter the name of Author");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the Bio details");
        string bio = Console.ReadLine();

        Author  author = new Author(name, bio, title, publicationYaer);
        author.DisplayInfo();

    }

}
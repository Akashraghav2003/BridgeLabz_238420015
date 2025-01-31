using System;

class BookDetails
{
	string title;
	string author;
	int price;
	//Create the constror to initialize the variables
	BookDetails(string title,string author,int price)
	{
		this.title = title;
		this.author = author;
		this.price = price;
	}
	
	
	//method to display the book details
	public void Display()
	{
		Console.WriteLine("Title is: "+title);
		Console.WriteLine("Author is: "+author);
		Console.WriteLine("Price: is "+price);
	}
	public static void Main()
	{
		Console.WriteLine("Enter the Title of the Book:");
		string title = Console.ReadLine();
		Console.WriteLine("Enter the Author of the Book:");
		string author = Console.ReadLine();
		Console.WriteLine("Enter the Price of the Book: ");
		int price = int.Parse(Console.ReadLine());
		//create the object of the class
		Book emp = new Book(title,author,price);
		emp.Display();
		
	}
	
	
}
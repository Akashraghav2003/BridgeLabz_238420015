using System;

class Addition{
	static void Main(String [] args ){
		
		Console.WriteLine("Enter The First Number");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter The Second Number");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Sum of two number: "+ (num1+num2));

	}
}

//Write a program to check if the first, second, or third number is the largest of the three.

using System;

class LargestNumber{

	static void Main(string [] args){
	
		//define the string  to hold the result
		string firstLargest="";
		string secondLargest="";
		string thirdLargest="";
		
		//Display Message to the user and taking a number1,number2 and number3 in input
		Console.WriteLine("Enter the first number: ");
		int firstNumber =Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the second number: ");
		int secondNumber =Convert.ToInt32(Console.ReadLine());//convert string into int
		
		Console.WriteLine("Enter the third number: ");
		int thirdNumber =Convert.ToInt32(Console.ReadLine());
		
		if(firstNumber>secondNumber && firstNumber>thirdNumber)
		{
			firstLargest="Yes.";
			thirdLargest="No.";
			secondLargest="No.";
		}
		
		else if(firstNumber<secondNumber && thirdNumber<secondNumber)
		{
			secondLargest="Yes.";
			firstLargest="No.";
			thirdLargest="No.";
		}
		else
		{
			thirdLargest="Yes.";
			secondLargest="No.";
			firstLargest="No.";
		}
			Console.WriteLine("Is the first number the largest? "+firstLargest+
							   " \nIs the second number the largest? "+secondLargest+
							   " \nIs the third number the largest? "+thirdLargest);
		
	}
}
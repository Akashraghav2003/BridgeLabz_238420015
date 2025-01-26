//Write a program to check if the first is the smallest of the 3 numbers.


using System;

class FirstSmallest{

	static void Main(){
	
		//define the string as result to store the result
		string result="";
		
		//taking input from user for number1,number2 and number3 in input
		Console.WriteLine("Enter the first number: ");
		int firstNumber =Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter the second number: ");
		int secondNumber =Convert.ToInt32(Console.ReadLine());//convert string into int
		
		Console.WriteLine("Enter the third number: ");
		int thirdNumber =Convert.ToInt32(Console.ReadLine());
		
		if(firstNumber<secondNumber && firstNumber<thirdNumber)
		{
			result="Yes.";
		}
		else
		{
			result="No.";
		}
		Console.WriteLine("Is the first number the smallest? "+result);
		
		
	}
}

//Write a program to create a basic calculator that can perform addition, subtraction, multiplication, and division. 
//The program should ask for two numbers (floating point) and perform all the operations
using System;

namespace Assignment{

	class Calculator
	{
		static void Main(string[] args)
		{
			//taking input in number1 variable
			Console.Write("Enter the first number: ");
			double number1 = Convert.ToDouble(Console.ReadLine());

			//read the second number as input from user
			Console.Write("Enter the second number: ");
			double number2 = Convert.ToDouble(Console.ReadLine());

			// Perform arithmetic operations
			double addition = number1 + number2; //add of two number
			double subtraction = number1 - number2;//subtraction of two number
			double multiplication = number1 * number2;//multiply of two number
			double division = number1 / number2; //divide of two number

			// Display the results
			Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+ number1 +" and " +number2+" is "+addition+" , " +subtraction+ " , " +multiplication+" , and "+ division);
			
		}
	}
}
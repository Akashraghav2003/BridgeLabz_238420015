// Factorial Using Recursion:
// Write a program that calculates the factorial of a number using a recursive function.
// ● Include modular code to separate input, calculation, and output processes.
using System;

class FactorialUsingRecursion{
	
	// Method to take an integer input from the user
	public static int Input(){
		Console.WriteLine("Enter the number: ");
		return Convert.ToInt32(Console.ReadLine());
	}

	// Recursive method to calculate factorial
	static int Factorial(int num){
		if(num == 0) return 1; // Base case
		if(num <= -1) return -1; // Handle negative numbers
		return num * Factorial(num - 1); // Recursive call
	}

	// Display the factorial result
	static void Display(){
		int num = Input();
		Console.WriteLine("Factorial of " + num + " is: " + Factorial(num));
	}

	public static void Main(){
		Display();
	}
}

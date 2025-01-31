// 2. Maximum of Three Numbers:
// Write a program that takes three integer inputs from the user and finds the maximum of the
// three numbers.
// ● Ensure your program follows best practices for organizing code into modular
// functions, such as separate functions for taking input and calculating the maximum
// value.
using System;

class MaximumNumber{
	
	// Method to take three integer inputs from the user
	public static int[] Input(){
		Console.WriteLine("Enter the first number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the second number: ");
		int num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the third number: ");
		int num3 = Convert.ToInt32(Console.ReadLine());

		return new int[]{num1, num2, num3};
	}

	// Method to determine the maximum number among the three inputs
	public static int Maximum(){
		int[] input = Input();
		int max = 0;

		if (input[0] > input[1] && input[0] > input[2]){
			max = input[0];
		}
		if (input[1] > input[0] && input[1] > input[2]){
			max = input[1];
		}
		if (input[2] > input[1] && input[2] > input[0]){
			max = input[2];
		}
		return max;
	}

	// Display the maximum number
	static void Display(){
		Console.WriteLine("Maximum number is: " + Maximum());
	}

	public static void Main(){
		Display();
	}
}

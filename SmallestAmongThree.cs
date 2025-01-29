// Write a program to find the smallest and the largest of the 3 numbers.

using System;

namespace Assignment4
{
	class SmallestOrLargestAmongThree
	{
		// Method to find the smallest and largest numbers among three inputs
		public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
		{
			int smallest = number1, largest = number1; // Assume first number is both smallest and largest

			// Check if the second number is smaller or larger
			if (number2 < smallest) smallest = number2;
			if (number2 > largest) largest = number2;

			// Check if the third number is smaller or larger
			if (number3 < smallest) smallest = number3;
			if (number3 > largest) largest = number3;

			// Return both smallest and largest as an array
			return new int[] { smallest, largest };
		}

		static void Main()
		{
			// Prompt the user to enter three numbers
			Console.WriteLine("Enter three numbers: ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			int number2 = Convert.ToInt32(Console.ReadLine());
			int number3 = Convert.ToInt32(Console.ReadLine());

			// Call the method and get the smallest and largest numbers
			int[] result = FindSmallestAndLargest(number1, number2, number3);

			// Display the results
			Console.WriteLine("Smallest: " + result[0] + ", Largest: " + result[1]);
		}
	}
}

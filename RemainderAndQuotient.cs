//.Write a program to take 2 numbers and print their quotient and reminder 


using System;

namespace Assignment4
{
	class RemainderAndQuotient
	{
		// Method to calculate the quotient and remainder
		public static int[] FindRemainderAndQuotient(int number, int divisor)
		{
			// Compute the quotient
			int quotient = number / divisor;

			// Compute the remainder
			int remainder = number % divisor;

			// Return both quotient and remainder as an array
			return new int[] { quotient, remainder };
		}

		public static void Main()
		{
			// Prompt the user to enter a number and divisor
			Console.WriteLine("Enter a number and a divisor: ");
			int number = Convert.ToInt32(Console.ReadLine());
			int divisor = Convert.ToInt32(Console.ReadLine());

			// Call the method to find quotient and remainder
			int[] result = FindRemainderAndQuotient(number, divisor);

			// Display the results
			Console.WriteLine("Quotient: " + result[0] + ", Remainder: " + result[1]);
		}
	}
}

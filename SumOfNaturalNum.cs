// Write a program to find the sum of n natural numbers using loop

using System;

namespace Assignment4
{
	class SumOfNaturalNum
	{
		// Method to calculate the sum of all natural numbers up to 'num'
		public int Sum(int num)
		{
			int sumOfNum = 0; // Initialize sum variable
			for (int i = 0; i <= num; i++) // Loop from 0 to num
			{
				sumOfNum += i; // Add each number to sum
			}
			return sumOfNum; // Return the final sum
		}

		static void Main(string[] args)
		{
			// Prompt the user to enter a number
			Console.Write("Enter the Number: ");
			int num = Convert.ToInt32(Console.ReadLine()); // Read and convert input to integer

			// Create an instance of the SumOfNaturalNum class
			SumOfNaturalNum obj = new SumOfNaturalNum();

			// Calculate the sum and display the result
			Console.WriteLine("The sum is: " + obj.Sum(num));
		}
	}
}

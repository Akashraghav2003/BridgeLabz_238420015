// Create a program to divide N numberOfChocolates of chocolates among M children. 
// Print the numberOfChocolates of chocolates each child will get and also the remaining chocolates


using System;

namespace Assignment4
{
	class ChocolateDistribution
	{
		// Method to calculate chocolates each child gets and remaining chocolates
		public static int[] DistributionOfChocolates(int numberOfChocolates, int numberOfChildren)
		{
			// Chocolates each child gets
			int chocolatesPerChild = numberOfChocolates / numberOfChildren;

			// Remaining chocolates after distribution
			int remainingChocolates = numberOfChocolates % numberOfChildren;

			// Return both values as an array
			return new int[] { chocolatesPerChild, remainingChocolates };
		}

		public static void Main()
		{
			// Prompt the user to enter total chocolates and children
			Console.WriteLine("Enter total chocolates and number of children: ");
			int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
			int numberOfChildren = Convert.ToInt32(Console.ReadLine());

			// Call the method to calculate distribution
			int[] result = DistributionOfChocolates(numberOfChocolates, numberOfChildren);

			// Display the results
			Console.WriteLine("Each child gets: " + result[0] + ", Remaining: " + result[1]);
		}
	}
}

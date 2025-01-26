// Create a program to find the mean height of players present in a football team.


using System;

namespace ArrayLevel1
{
    class MeanHeight
    {
        static void Main(string[] args)
        {
            double[] heights = new double[11]; // Array to store heights of 11 players
            double sum = 0.0; // Variable to accumulate the sum of heights

            Console.WriteLine("Enter the heights of 11 players:");

            // Loop to get input for each player's height
            for (int i = 0; i < heights.Length; i++)
            {
                Console.WriteLine("Enter height of player " + (i + 1) + ":");
                heights[i] = Convert.ToDouble(Console.ReadLine()); // Store height in the array
                sum += heights[i]; // Add the height to the total sum
            }

            // Calculate the mean height by dividing the sum by the number of players
            double mean = sum / heights.Length;

            // Display the mean height
            Console.WriteLine("The mean height of the football team is: " + mean);
        }
    }
}

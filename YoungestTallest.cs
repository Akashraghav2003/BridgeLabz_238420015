//Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on their ages and the tallest among the friends based on their heights


using System;

namespace ArrayLevel2
{
    class YoungestTallest
    {
        static void Main()
        {
            // Arrays to store ages and heights
            int[] ages = new int[3];
            float[] heights = new float[3];
            string[] names = { "Amar", "Akbar", "Anthony" };

            // Input ages and heights for each friend
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter the age of {names[i]}: ");
                ages[i] = int.Parse(Console.ReadLine());

                Console.Write($"Enter the height of {names[i]} (in cm): ");
                heights[i] = float.Parse(Console.ReadLine());
            }

            // Initialize variables to track the youngest and tallest friend
            int youngestIndex = 0;  // Index of the youngest friend
            int tallestIndex = 0;  // Index of the tallest friend

            // Loop through the arrays to find the youngest and tallest
            for (int i = 1; i < names.Length; i++)
            {
                if (ages[i] < ages[youngestIndex])
                {
                    youngestIndex = i; // Update youngest friend's index
                }
                if (heights[i] > heights[tallestIndex])
                {
                    tallestIndex = i; // Update tallest friend's index
                }
            }

            // Output the youngest friend
            Console.WriteLine($"\nThe youngest friend is {names[youngestIndex]}, with an age of {ages[youngestIndex]} years.");

            // Output the tallest friend
            Console.WriteLine($"The tallest friend is {names[tallestIndex]}, with a height of {heights[tallestIndex]} cm.");
        }
    }
}


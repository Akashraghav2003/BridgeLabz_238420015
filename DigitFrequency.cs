//Create a program to take a number as input find the frequency of each digit in the number using an array and display the frequency of each digit



using System;

namespace ArrayLevel2
{
    class DigitFrequency
    {
        static void Main()
        {
            // Take input for the number
            Console.Write("Enter a number: ");
            long number = Convert.ToInt64(Console.ReadLine());

            // Array to store frequency of digits (0-9)
            int[] frequency = new int[10];

            // Process each digit in the number
            while (number > 0)
            {
                int digit = (int)(number % 10); // Extract the last digit
                frequency[digit]++;            // Increment its frequency
                number /= 10;                  // Remove the last digit
            }

            // Display the frequency of each digit
            Console.WriteLine("\nDigit Frequency:");
            for (int i = 0; i < 10; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine($"Digit {i}: {frequency[i]}");
                }
            }
        }
    }
}

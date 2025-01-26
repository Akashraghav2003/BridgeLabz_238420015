



using System;

namespace ArrayLevel1
{
    class FactorCalculator2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to find its factors: ");
            int number = int.Parse(Console.ReadLine());

            // Ensure the number is positive
            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            int maxFactor = 10; // Initial capacity for the factors array
            int[] factors = new int[maxFactor]; // Array to store factors
            int index = 0;

            // Loop to find all factors of the number
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) // If 'i' is a factor of the number
                {
                    // Check if the array needs resizing
                    if (index == maxFactor)
                    {
                        // Double the array size
                        maxFactor *= 2;
                        int[] temp = new int[maxFactor];
                        // Copy existing factors to the new array
                        for (int j = 0; j < factors.Length; j++)
                        {
                            temp[j] = factors[j];
                        }
                        // Reassign the reference of 'factors' to the new array
                        factors = temp;
                    }
                    factors[index] = i; // Store the factor
                    index++;
                }
            }

            // Output the factors
            Console.WriteLine("Factors of " + number + ":");
            for (int i = 0; i < index; i++)
            {
                Console.Write(factors[i] + " ");
            }
        }
    }
}

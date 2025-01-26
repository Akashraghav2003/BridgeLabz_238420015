// Write a program to store multiple values in an array up to a maximum of 10 or until the user enters a 0 or a negative number. 
// Show all the numbers as well as the sum of all numbers 


using System;

namespace ArrayLevel1
{
    class SumOfUserInputs
    {
        static void Main(string[] args)
        {
            double[] numberArray = new double[10]; // Array to store up to 10 numbers
            double total = 0.0; // Variable to store the sum of numbers
            int index = 0;

            Console.WriteLine("Enter numbers :");

            // Loop to get user input until a condition is met (0, negative, or array full)
            while (true)
            {
                Console.WriteLine("Enter number " + (index + 1) + ":"); // Prompt for each number
                double number = double.Parse(Console.ReadLine());

                if (number <= 0 || index == 10) // Stop if input is 0, negative, or array is full
                {
                    break;
                }

                numberArray[index] = number; // Store the number in the array
                index++;
            }

            Console.WriteLine("Numbers entered:");

            // Output the numbers entered by the user and calculate the total sum
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numberArray[i]); // Display each number
                total += numberArray[i]; // Add the number to the total sum
            }

            // Display the total sum
            Console.WriteLine("Total sum of numbers: " + total);
        }
    }
}

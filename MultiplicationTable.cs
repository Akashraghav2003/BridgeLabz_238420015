//Create a program to find the multiplication table of a number entered by the user from 6 to 9 and display the result


using System;

namespace ArrayLevel1
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number and take input
            Console.WriteLine("Enter a number to generate its multiplication table from 6 to 9: ");
            int number = int.Parse(Console.ReadLine());

            int[] result = new int[4]; // Array to store the results for 6 to 9

            // Calculate the multiplication results for numbers 6 to 9
            for (int i = 6; i <= 9; i++)
            {
                result[i - 6] = number * i; // Store each result in the array
            }

            Console.WriteLine("Multiplication Table:");

            // Display the multiplication table
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + result[i - 6]);
            }
        }
    }
}

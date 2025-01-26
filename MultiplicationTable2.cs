// Create a program to print a multiplication table of a number.

using System;

namespace ArrayLevel
{
    class MultiplicationTable2
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Declare an array to store the first 10 multiples of the number
            int[] tableOfNum = new int[10];

            // Calculate the multiplication table and store the results in the array
            for (int i = 1; i <= 10; i++)
            {
                // Store each result in the array, where index (i - 1) corresponds to the multiplier
                tableOfNum[i - 1] = number * i;
            }

            Console.WriteLine("Multiplication Table:");

            // Display the multiplication table by accessing each element in the array
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + tableOfNum[i - 1]);
            }
        }
    }
}

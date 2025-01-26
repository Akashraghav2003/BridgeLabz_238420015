// Create a program to take a number as input and reverse the number. To do this, store the digits of the number in an array and display the array in reverse order
// Hint => 
// Take user input for a number. 
// Find the count of digits in the number. 
// Find the digits in the number and save them in an array
// Create an array to store the elements of the digits array in reverse order
// Finally, display the elements of the array in reverse order  


using System;

namespace ArrayLevel2
{
    class ReverseNumber
    {
        static void Main()
        {
            // Input the number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine()); // Use long to handle large numbers

            // Find the count of digits in the number
            int digitCount = 0;
            long tempNumber = number;

            while (tempNumber != 0)
            {
                tempNumber /= 10;
                digitCount++;
            }

            // Create an array to store the digits
            int[] digits = new int[digitCount];
            int index = 0;

            // Extract the digits of the number and store them in the array
            while (number != 0)
            {
                digits[index++] = (int)(number % 10); // Store the last digit
                number /= 10; // Remove the last digit
            }

            // Display the digits in reverse order (stored as they already are in reverse)
            Console.WriteLine("\nThe reversed number is:");
            foreach (int digit in digits)
            {
                Console.Write(digit);
            }

            Console.WriteLine();
        }
    }
}

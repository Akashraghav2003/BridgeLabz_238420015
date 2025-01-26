// Create a program to save odd and even numbers into odd and even arrays between 1 to the number entered by the user. 
// Finally, print the odd and even numbers array

using System;

namespace ArrayLevel1
{
    class SeparateOddEven
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a natural number and take input
            Console.Write("Enter a natural number: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the number is greater than 0
            if (number <= 0)
            {
                Console.WriteLine("Error: Please enter a natural number greater than 0.");
                return;
            }

            // Create arrays to store odd and even numbers, with a size of half the number (rounded up for odd numbers)
            int[] oddNumbers = new int[number / 2 + 1];
            int[] evenNumbers = new int[number / 2 + 1];
            int oddIndex = 0, evenIndex = 0;

            // Separate odd and even numbers
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0) // Even numbers
                {
                    evenNumbers[evenIndex] = i;
                    evenIndex++;
                }
                else // Odd numbers
                {
                    oddNumbers[oddIndex] = i;
                    oddIndex++;
                }
            }

            // Output the odd numbers
            Console.WriteLine("Odd Numbers:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.WriteLine(oddNumbers[i] + " ");
            }

            // Output the even numbers
            Console.WriteLine("Even Numbers:");
            for (int i = 0; i < evenIndex; i++)
            {
                Console.WriteLine(evenNumbers[i] + " ");
            }
        }
    }
}

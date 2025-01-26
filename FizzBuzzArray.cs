
// Write a program FizzBuzz, take a number as user input and if it is a positive integer loop from 0 to the number and save the number,
// but for multiples of 3 save "Fizz" instead of the number, for multiples of 5 save "Buzz", and for multiples of both save "FizzBuzz". 
// Finally, print the array results for each index position in the format Position 1 = 1, …, Position 3 = Fizz,...



using System;

namespace ArrayLevel
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a positive integer
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            // Check if the entered number is positive
            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            // Create a string array to store the results of the FizzBuzz logic
            string[] results = new string[number + 1];

            // Loop through numbers 1 to the given number and apply FizzBuzz logic
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    results[i] = "FizzBuzz"; // For numbers divisible by both 3 and 5
                else if (i % 3 == 0)
                    results[i] = "Fizz"; // For numbers divisible by 3
                else if (i % 5 == 0)
                    results[i] = "Buzz"; // For numbers divisible by 5
                else
                    results[i] = i.ToString(); // For other numbers, store the number itself
            }

            // Display the results along with their index positions
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Position " + i + " = " + results[i]);
            }
        }
    }
}

// Create a program to store the digits of the number in an array and find the largest and second largest element of the array.
// Hint => 
// Create a number variable and take user input. 
// Define an array to store the digits. Set the size of the array to maxDigit variable initially set to 10
// Create an integer variable index with the value 0 to reflect the array index.
// Use a loop to iterate until the number is not equal to 0.
// Remove the last digit from the number in each iteration and add it to the array.
// Increment the index by 1 in each iteration and if the index count equals maxDigit then break out of the loop and the remaining digits are not added to the array
// Define variable to store largest and second largest digit and initialize it to zero
// Loop through the array and use conditional statements to find the largest and second largest number in the array
// Finally display the largest  and second-largest number


using System;

namespace ArrayLevel2
{
    class LargestSecondLargest
    {
        static void Main()
        {
            // Input the number with max ten digit
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Initialize array and variables
            int maxDigit = 10; // Maximum size of the array
            int[] digits = new int[maxDigit];
            int index = 0; // To keep track of array index

            // Extract digits from the number and store them in the array
            while (number != 0)
            {
                if (index == maxDigit)
                {
                    Console.WriteLine("Maximum digit limit reached. Remaining digits are ignored.");
                    break;
                }

                digits[index] = number % 10; // Get the last digit
                number /= 10;               // Remove the last digit
                index++;                    // Move to the next index
            }

            // Initialize variables to store the largest and second largest numbers
            int largest = 0;
            int secondLargest = 0;

            // Find the largest and second largest digits
            for (int i = 0; i < index; i++)
            {
                if (digits[i] > largest)
                {
                    // Update second largest before updating largest
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    // Update second largest if the digit is not equal to the largest
                    secondLargest = digits[i];
                }
            }

            // Display the results
            Console.WriteLine($"\nThe largest digit is: {largest}");
            Console.WriteLine($"The second largest digit is: {secondLargest}");
        }
    }
}

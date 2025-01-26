//Rework the program 2, especially the Hint: if index equals maxDigit, we break from the loop. Here we want to modify to increase the size of the array i,e maxDigit by 10 if the index is equal to maxDigit. This is done to consider all digits to find the largest and second-largest number 
//Hint => 
//In Hint f inside the loop if the index is equal to maxDigit, increase maxDigit and make digits array to store more elements. 
//To do this, we need to create a new temp array of size maxDigit, copy from the current digits array the digits into the temp array, and assign the current digits array to the temp array
//Now the digits array will be able to store all digits of the number in the array and then find the largest and second largest number


using System;
using System.Numerics; // Required for BigInteger

namespace ArrayLevel2
{
    class LargestSecondLargest2
    {
        static void Main()
        {
            // Input the number
            Console.Write("Enter a number: ");
            BigInteger number = BigInteger.Parse(Console.ReadLine()); // Use BigInteger for large numbers

            // Initialize array and variables
            int maxDigit = 10; // Initial size of the array
            int[] digits = new int[maxDigit];
            int index = 0; // To keep track of the array index

            // Extract digits from the number and store them in the array
            while (number != 0)
            {
                // If the index equals maxDigit, increase array size
                if (index == maxDigit)
                {
                    maxDigit += 10; // Increase the size by 10
                    int[] temp = new int[maxDigit]; // Create a temporary array with the new size
                    Array.Copy(digits, temp, digits.Length); // Copy existing digits to the temp array
                    digits = temp; // Assign the temp array to digits
                }

                digits[index] = (int)(number % 10); // Get the last digit
                number /= 10;                       // Remove the last digit
                index++;                            // Move to the next index
            }

            // Initialize variables to store the largest and second-largest numbers
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

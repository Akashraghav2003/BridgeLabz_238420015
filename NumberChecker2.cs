// Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. 
// Make sure all are static methods


using System;

namespace Assignment4 {
    public static class NumberChecker2 {
        // Method to count the digits in a number
        public static int CountDigits(int number) {
            int count = 0;
            while (number > 0) {
                count++;
                number /= 10;
            }
            return count;
        }

        // Method to store digits of the number in a digits array
        public static int[] GetDigitsArray(int number) {
            int count = CountDigits(number);
            int[] digits = new int[count];
            for (int i = count - 1; i >= 0; i--) {
                digits[i] = number % 10;
                number /= 10;
            }
            return digits;
        }

        // Method to find the sum of the digits
        public static int SumOfDigits(int[] digits) {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++) {
                sum += digits[i];
            }
            return sum;
        }

        // Method to find the sum of squares of the digits
        public static int SumOfSquaresOfDigits(int[] digits) {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++) {
                sum += digits[i] * digits[i];
            }
            return sum;
        }

        // Method to check if a number is a Harshad number
        public static bool IsHarshadNumber(int number, int[] digits) {
            int sum = SumOfDigits(digits);
            return number % sum == 0;
        }

        // Method to find the frequency of each digit in the number
        public static int[,] GetDigitFrequency(int[] digits) {
            int[,] frequency = new int[10, 2];
            for (int i = 0; i < 10; i++) {
                frequency[i, 0] = i; // Store the digit
                frequency[i, 1] = 0; // Initialize the frequency
            }

            for (int i = 0; i < digits.Length; i++) {
                frequency[digits[i], 1]++;
            }

            return frequency;
        }

        // Main method to test all methods
        public static void Main() {
			
			Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Count digits
            Console.WriteLine("Number: " + number);
            Console.WriteLine("Count of Digits: " + CountDigits(number));

            // Get digits array
            int[] digits = GetDigitsArray(number);
            Console.Write("Digits Array: ");
            for (int i = 0; i < digits.Length; i++) {
                Console.Write(digits[i]);
                if (i < digits.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();

            // Sum of digits
            Console.WriteLine("Sum of Digits: " + SumOfDigits(digits));

            // Sum of squares of digits
            Console.WriteLine("Sum of Squares of Digits: " + SumOfSquaresOfDigits(digits));

            // Check if Harshad number
            Console.WriteLine("Is Harshad Number: " + IsHarshadNumber(number, digits));

            // Frequency of digits
            int[,] frequency = GetDigitFrequency(digits);
            Console.WriteLine("Digit Frequency:");
            for (int i = 0; i < 10; i++) {
                if (frequency[i, 1] > 0)
                    Console.WriteLine("Digit " + frequency[i, 0] + ": " + frequency[i, 1] + " times");
            }
        }
    }
}

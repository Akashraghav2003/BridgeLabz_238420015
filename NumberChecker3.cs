
// 4.Extend or Create a NumberChecker utility class and perform the following task.
// Call from the main() method the different methods and display results. Make sure all are static methods



using System;

namespace Assignment4 {
    public static class NumberChecker {
        // Method to count the digits in a number
        public static int CountDigits(int number) {
            int count = 0;
            while (number > 0) {
                count++;
                number /= 10;
            }
            if (count > 0) {
                return count;
            } else {
                return 0;
            }
        }

        // Method to store digits of the number in a digits array
        public static int[] GetDigitsArray(int number) {
            int count = CountDigits(number);
            int[] digits = new int[count];
            for (int i = count - 1; i >= 0; i--) {
                digits[i] = number % 10;
                number /= 10;
            }
            if (digits.Length > 0) {
                return digits;
            } else {
                return new int[0];
            }
        }

        // Method to reverse the digits array
        public static int[] ReverseArray(int[] digits) {
            int length = digits.Length;
            int[] reversed = new int[length];
            for (int i = 0; i < length; i++) {
                reversed[i] = digits[length - i - 1];
            }
            if (reversed.Length > 0) {
                return reversed;
            } else {
                return new int[0];
            }
        }

        // Method to compare two arrays and check if they are equal
        public static bool AreArraysEqual(int[] array1, int[] array2) {
            if (array1.Length != array2.Length) {
                return false;
            } else {
                for (int i = 0; i < array1.Length; i++) {
                    if (array1[i] != array2[i]) {
                        return false;
                    }
                }
                return true;
            }
        }

        // Method to check if a number is a palindrome
        public static bool IsPalindrome(int number) {
            int[] digits = GetDigitsArray(number);
            int[] reversed = ReverseArray(digits);
            if (AreArraysEqual(digits, reversed)) {
                return true;
            } else {
                return false;
            }
        }

        // Method to check if a number is a duck number
        public static bool IsDuckNumber(int number) {
            int[] digits = GetDigitsArray(number);
            for (int i = 1; i < digits.Length; i++) { // Start from index 1 to ignore leading zeros
                if (digits[i] == 0) {
                    return true;
                }
            }
            return false;
        }

        // Main method to test all methods
        public static void Main() {
            int number = 12321; // Example palindrome number
            int duckNumber = 1023; // Example duck number

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

            // Reverse digits array
            int[] reversed = ReverseArray(digits);
            Console.Write("Reversed Digits Array: ");
            for (int i = 0; i < reversed.Length; i++) {
                Console.Write(reversed[i]);
                if (i < reversed.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();

            // Check if arrays are equal
            Console.WriteLine("Are Digits and Reversed Arrays Equal: " + AreArraysEqual(digits, reversed));

            // Check if number is a palindrome
            Console.WriteLine("Is Palindrome: " + IsPalindrome(number));

            // Check if number is a duck number
            Console.WriteLine("Number: " + duckNumber);
            Console.WriteLine("Is Duck Number: " + IsDuckNumber(duckNumber));
        }
    }
}

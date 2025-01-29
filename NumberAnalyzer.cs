 // Write a program to take user input for 5 numbers and check whether a number is positive or negative. Further for positive numbers check if the number is even or odd. 
 // Finally compare the first and last elements of the array and display if they are equal, greater, or less
 
using System;

namespace Assignment4 {

    public class NumberAnalyzer {

        // Method to check if a number is positive or negative
        public static bool IsPositive(int number) {
            if (number >= 0) {
                return true; // Positive number
            } else {
                return false; // Negative number
            }
        }

        // Method to check if a number is even or odd
        public static bool IsEven(int number) {
            if (number % 2 == 0) {
                return true; // Even number
            } else {
                return false; // Odd number
            }
        }

        // Method to compare two numbers
        public static int Compare(int number1, int number2) {
            if (number1 > number2) {
                return 1; // First number is greater
            } else if (number1 == number2) {
                return 0; // Numbers are equal
            } else {
                return -1; // First number is less
            }
        }

        static void Main(string[] args) {
            // Array to store 5 numbers
            int[] numbers = new int[5];

            // Input 5 numbers from the user
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Analysis of Numbers:");
            // Loop through the array and analyze each number
            for (int i = 0; i < numbers.Length; i++) {
                if (IsPositive(numbers[i])) {
                    Console.Write("Number " + numbers[i] + " is Positive");
                    if (IsEven(numbers[i])) {
                        Console.WriteLine(" and Even.");
                    } else {
                        Console.WriteLine(" and Odd.");
                    }
                } else {
                    Console.WriteLine("Number " + numbers[i] + " is Negative.");
                }
            }

            // Compare the first and last elements of the array
            Console.WriteLine("Comparison of First and Last Elements:");
            int comparisonResult = Compare(numbers[0], numbers[numbers.Length - 1]);
            if (comparisonResult == 1) {
                Console.WriteLine("The first number is greater than the last number.");
            } else if (comparisonResult == 0) {
                Console.WriteLine("The first number is equal to the last number.");
            } else {
                Console.WriteLine("The first number is less than the last number.");
            }
        }
    }
}

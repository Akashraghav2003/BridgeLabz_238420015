// Write a program to find the sum of n natural numbers using recursive method and compare the result with the formulae n*(n+1)/2 an
// show the result from both computations is correct. 



using System;

namespace Assignment4 {

    class NaturalNumberSum {

        // Method to find the sum of n natural numbers using recursion
        public static int SumUsingRecursion(int n) {
            if (n == 1) {
                return 1; // Base case
            }
            return n + SumUsingRecursion(n - 1); // Recursive case
        }

        // Method to find the sum of n natural numbers using the formula n*(n+1)/2
        public static int SumUsingFormula(int n) {
            return n * (n + 1) / 2;
        }

        static void Main(string[] args) {
            // Taking user input
            Console.Write("Enter a natural number (greater than 0): ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the input is a natural number
            if (number <= 0) {
                Console.WriteLine("Invalid input! Please enter a natural number greater than 0.");
                return;
            }

            // Calculate the sum using recursion
            int sumRecursive = SumUsingRecursion(number);

            // Calculate the sum using the formula
            int sumFormula = SumUsingFormula(number);

            // Compare and print the results
            Console.WriteLine("Sum using recursion: " + sumRecursive);
            Console.WriteLine("Sum using formula: " + sumFormula);

            if (sumRecursive == sumFormula) {
                Console.WriteLine("Both methods give the same result. ");
            } else {
                Console.WriteLine("The results do not match.");
            }
        }
    }
}

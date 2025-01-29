// Create a program to find the factors of a number taken as user input, 
// store the factors in an array and display the factors. Also find the sum, 
// sum of square of factors and product of the factors and display the results


using System;

namespace Assignment4 {

    class FactorFinder {

        // Method to find all factors of a number and return them in an array
        public static int[] Factors(int num) {
            // First, count the total number of factors
            int count = 0;
            for (int i = 1; i <= (num / 2); i++) {
                if (num % i == 0) {
                    count++;
                }
            }
            // Initialize an array to store the factors
            int[] factor = new int[count + 1]; // +1 to include the number itself
            int index = 0;

            // Populate the array with factors
            for (int i = 1; i <= (num / 2); i++) {
                if (num % i == 0) {
                    factor[index] = i;
                    index++;
                }
            }
            factor[index] = num; // Include the number itself as a factor
            return factor;
        }

        // Method to calculate the sum of all factors
        public static int SumOfFactors(int[] factor) {
            int sum = 0;
            for (int i = 0; i < factor.Length; i++) {
                sum += factor[i];
            }
            return sum;
        }

        // Method to calculate the product (multiplication) of all factors
        public static int MultiplyOfFactors(int[] factor) {
            int mul = 1;
            for (int i = 0; i < factor.Length; i++) {
                mul *= factor[i];
            }
            return mul;
        }

        // Method to calculate the sum of the squares of all factors
        public static double SquareOfFactors(int[] factor) {
            double sum = 0;
            for (int i = 0; i < factor.Length; i++) {
                sum += Math.Pow(factor[i], 2); // Square each factor and add to the sum
            }
            return sum;
        }

        // Main method
        static void Main(string[] args) {
            // Prompt user to input a number
            Console.Write("Enter the Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Call the Factors method to get all factors of the number
            int[] result = Factors(num);

            // Calculate the sum, product, and sum of squares of factors
            int sum = SumOfFactors(result);
            int multiply = MultiplyOfFactors(result);
            double square = SquareOfFactors(result);

            // Print all factors
            Console.WriteLine("Factors of the number:");
            for (int i = 0; i < result.Length; i++) {
                Console.WriteLine(result[i]);
            }

            // Print the calculated results
            Console.WriteLine("Sum of factors: " + sum);
            Console.WriteLine("Product of factors: " + multiply);
            Console.WriteLine("Sum of squares of factors: " + square);
        }
    }
}

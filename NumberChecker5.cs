// Extend or Create a NumberChecker utility class and perform the following task. 
// Call from the main() method the different methods and display results. Make sure all are static methods



using System;

namespace Assignment4 {
    public static class NumberChecker5 {
        // Method to find factors of a number and return them as an array
        public static int[] FindFactors(int number) {
            int count = 0;
            // Count how many factors there are
            for (int i = 1; i <= number; i++) {
                if (number % i == 0) {
                    count++;
                }
            }

            // Create an array to store the factors
            int[] factors = new int[count];
            int index = 0;
            for (int i = 1; i <= number; i++) {
                if (number % i == 0) {
                    factors[index] = i;
                    index++;
                }
            }
            return factors;
        }

        // Method to find the greatest factor of a number using the factors array
        public static int GreatestFactor(int[] factors) {
            if (factors.Length > 0) {
                return factors[factors.Length - 1];
            }
            return -1; // Return -1 if no factors are found (although for any number > 0, there will always be factors)
        }

        // Method to find the sum of the factors using the factors array
        public static int SumOfFactors(int[] factors) {
            int sum = 0;
            foreach (int factor in factors) {
                sum += factor;
            }
            return sum;
        }

        // Method to find the product of the factors using the factors array
        public static int ProductOfFactors(int[] factors) {
            int product = 1;
            foreach (int factor in factors) {
                product *= factor;
            }
            return product;
        }

        // Method to find the product of the cube of the factors using the factors array (using Math.Pow)
        public static double ProductOfCubesOfFactors(int[] factors) {
            double product = 1;
            foreach (int factor in factors) {
                product *= Math.Pow(factor, 3);
            }
            return product;
        }

        // Method to check if a number is a perfect number
        public static bool IsPerfectNumber(int number) {
            int[] factors = FindFactors(number);
            int sum = SumOfFactors(factors) - number; // Exclude the number itself
            return sum == number;
        }

        // Method to check if a number is an abundant number
        public static bool IsAbundantNumber(int number) {
            int[] factors = FindFactors(number);
            int sum = SumOfFactors(factors) - number; // Exclude the number itself
            return sum > number;
        }

        // Method to check if a number is a deficient number
        public static bool IsDeficientNumber(int number) {
            int[] factors = FindFactors(number);
            int sum = SumOfFactors(factors) - number; // Exclude the number itself
            return sum < number;
        }

        // Method to check if a number is a strong number
        public static bool IsStrongNumber(int number) {
            int sum = 0;
            int temp = number;
            while (temp > 0) {
                int digit = temp % 10;
                sum += Factorial(digit);  // Add the factorial of the digit
                temp /= 10;
            }
            return sum == number;
        }

        // Helper method to calculate the factorial of a number
        public static int Factorial(int n) {
            if (n == 0 || n == 1) {
                return 1;
            }
            int result = 1;
            for (int i = 2; i <= n; i++) {
                result *= i;
            }
            return result;
        }

        // Main method to test all methods
        public static void Main() {
            Console.WriteLine("Enter a number for factor related checks:");
            int number = Convert.ToInt32(Console.ReadLine());

            // Find factors
            int[] factors = FindFactors(number);
            Console.WriteLine("\nFactors of " + number + ": " + string.Join(", ", factors));

            // Greatest factor
            Console.WriteLine("Greatest Factor: " + GreatestFactor(factors));

            // Sum of factors
            Console.WriteLine("Sum of Factors: " + SumOfFactors(factors));

            // Product of factors
            Console.WriteLine("Product of Factors: " + ProductOfFactors(factors));

            // Product of cubes of factors
            Console.WriteLine("Product of Cubes of Factors: " + ProductOfCubesOfFactors(factors));

            // Check if number is a perfect number
            Console.WriteLine("Is Perfect Number: " + IsPerfectNumber(number));

            // Check if number is an abundant number
            Console.WriteLine("Is Abundant Number: " + IsAbundantNumber(number));

            // Check if number is a deficient number
            Console.WriteLine("Is Deficient Number: " + IsDeficientNumber(number));

            // Check if number is a strong number
            Console.WriteLine("Is Strong Number: " + IsStrongNumber(number));
        }
    }
}

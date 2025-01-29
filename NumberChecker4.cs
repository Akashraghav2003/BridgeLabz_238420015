  // Extend or Create a NumberChecker utility class and perform the following task.
  // Call from the main() method the different methods and display results.Make sure all are static methods


using System;

namespace Assignment4 {
    public static class NumberChecker4 {
        // Method to check if a number is a prime number
        public static bool IsPrime(int number) {
            if (number <= 1) {
                return false;
            }
            for (int i = 2; i * i <= number; i++) {
                if (number % i == 0) {
                    return false;
                }
            }
            return true;
        }

        // Method to check if a number is a neon number
        public static bool IsNeonNumber(int number) {
            int square = number * number;
            int sumOfDigits = 0;
            while (square > 0) {
                sumOfDigits += square % 10;
                square /= 10;
            }
            return sumOfDigits == number;
        }

        // Method to check if a number is a spy number
        public static bool IsSpyNumber(int number) {
            int sum = 0;
            int product = 1;
            while (number > 0) {
                int digit = number % 10;
                sum += digit;
                product *= digit;
                number /= 10;
            }
            return sum == product;
        }

        // Method to check if a number is an automorphic number
        public static bool IsAutomorphicNumber(int number) {
            int square = number * number;
            while (square > 0) {
                if (square % 10 != number % 10) {
                    return false;
                }
                square /= 10;
                number /= 10;
            }
            return true;
        }

        // Method to check if a number is a buzz number
        public static bool IsBuzzNumber(int number) {
            return number % 7 == 0 || number % 10 == 7;
        }

        // Main method to test all methods
        public static void Main() {
            Console.WriteLine("Enter a number for prime check:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number for neon check:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number for spy number check:");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number for automorphic check:");
            int number4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number for buzz number check:");
            int number5 = Convert.ToInt32(Console.ReadLine());

            // Check if number is prime
            Console.WriteLine("\nNumber: " + number1);
            Console.WriteLine("Is Prime: " + IsPrime(number1));

            // Check if number is neon
            Console.WriteLine("\nNumber: " + number2);
            Console.WriteLine("Is Neon Number: " + IsNeonNumber(number2));

            // Check if number is spy
            Console.WriteLine("\nNumber: " + number3);
            Console.WriteLine("Is Spy Number: " + IsSpyNumber(number3));

            // Check if number is automorphic
            Console.WriteLine("\nNumber: " + number4);
            Console.WriteLine("Is Automorphic Number: " + IsAutomorphicNumber(number4));

            // Check if number is buzz
            Console.WriteLine("\nNumber: " + number5);
            Console.WriteLine("Is Buzz Number: " + IsBuzzNumber(number5));
        }
    }
}

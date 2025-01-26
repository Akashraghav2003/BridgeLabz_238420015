// Create a program to print the greatest factor of a number beside itself using a loop.


using System;

class GreatestFactor {
    static void Main() {
        // Get the input number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize the greatest factor variable
        int greatestFactor = 1;

        // Loop from number - 1 down to 1
        for (int i = number - 1; i >= 1; i--) {
            // Check if the number is perfectly divisible by i
            if (number % i == 0) {
                greatestFactor = i;
                break; // Exit the loop as we found the greatest factor
            }
        }

        // Display the greatest factor
        Console.WriteLine("The greatest factor of {0} (besides itself) is: {1}", number, greatestFactor);
    }
}

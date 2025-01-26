using System;

class PowerCalculator
{
    static void Main()
    {
        // Input variables
        int number, power, result = 1;

        // Get user input
        Console.WriteLine("Enter the number:");
        number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the power:");
        power = Convert.ToInt32(Console.ReadLine());

        // Calculate power using a for loop
        for (int i = 1; i <= power; i++)
        {
            result *= number; // Multiply result by the number
        }

        // Print the result
        Console.WriteLine("The result of " + number + " raised to the power " + power + " is: " + result);
    }
}

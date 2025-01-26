using System;

class FactorFinder
{
    static void Main()
    {
        // Input variable
        int number;

        // Get user input
        Console.WriteLine("Enter a number:");
        number = Convert.ToInt32(Console.ReadLine());

        // Loop backward from 100 to 1
        Console.WriteLine("Multiples of " + number + " below 100 are:");
        for (int i = 1; i < number; i--)
        {
            if (number%i == 0) // Check number is divisible by i
            {
                Console.WriteLine(i);
            }
        }
    }
}

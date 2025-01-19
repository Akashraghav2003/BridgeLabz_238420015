using System;

class PowerCalculation{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the base value: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the exponent value: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        double result = Math.Pow(num1, num2);

        Console.WriteLine(num1 + " raised to the power of " + num2 + " is: " + result);
    }
}

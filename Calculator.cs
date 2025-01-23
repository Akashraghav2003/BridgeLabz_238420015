using System;

class Calculator
{
    static void Main()
    {
        // Input variables
        double first, second;
        string operators;

        // Take inputs
        Console.WriteLine("Enter the first number:");
        first = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        second = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the operator (+, -, *, /):");
        operators = Console.ReadLine();//take operator in string format

        // Perform operation using switch...case
        switch (operators)
        {
            case "+":
                Console.WriteLine("The result is: " + (first + second));
                break;
            case "-":
                Console.WriteLine("The result is: " + (first - second));
                break;
            case "*":
                Console.WriteLine("The result is: " + (first * second));
                break;
            case "/":
                if (second != 0)
                {
                    Console.WriteLine("The result is: " + (first / second));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}

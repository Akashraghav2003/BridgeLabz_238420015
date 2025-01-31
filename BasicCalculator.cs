// Basic Calculator:
// Write a program that performs basic mathematical operations (addition, subtraction,
// multiplication, division) based on user input.
// ● Each operation should be performed in its own function, and the program should
// prompt the user to choose which operation to perform.
using System;

class BasicCalculator{
	
    // Method for Addition
    public static double Add(double a, double b){
        return a + b;
    }

    // Method for Subtraction
    public static double Subtract(double a, double b){
        return a - b;
    }

    // Method for Multiplication
    public static double Multiply(double a, double b){
        return a * b;
    }

    // Method for Division
    public static double Divide(double a, double b){
        if (b == 0){
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN; // Not a Number
        }
        return a / b;
    }

    // Method to display the result
    public static void Display(double result){
        Console.WriteLine("Result: " + result);
    }

    public static void Main(){
        Console.WriteLine("Basic Calculator");
        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");

        // Taking user choice
        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Taking two numbers as input
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        // Performing calculation based on user's choice
        switch (choice){
            case 1:
                result = Add(num1, num2);
                break;
            case 2:
                result = Subtract(num1, num2);
                break;
            case 3:
                result = Multiply(num1, num2);
                break;
            case 4:
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid choice! Please enter a number between 1 and 4.");
                return;
        }

        // Display the result
        Display(result);
    }
}

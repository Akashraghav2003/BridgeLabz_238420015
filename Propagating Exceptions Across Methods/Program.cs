using System;
using System.IO;

class Program
{
    static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
            throw new ArgumentException("Amount and rate must be positive");

        return amount * rate * years / 100;
    }

    static int PerformDivision(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new DivideByZeroException("Cannot divide by zero.");

        return numerator / denominator;
    }

    static void Method1()
    {
        throw new ArithmeticException("Attempted to divide by zero.");
    }

    static void Method2()
    {
        Method1();
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            double interest = CalculateInterest(amount, rate, years);
            Console.WriteLine("Calculated Interest: " + interest);

            Console.Write("Enter numerator: ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            int result = PerformDivision(numerator, denominator);
            Console.WriteLine("Division Result: " + result);

            Method2();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Invalid input: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (ArithmeticException ex)
        {
            Console.WriteLine("Handled exception in Main: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}

using System;
using System.IO;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount
{
    public double Balance { get; private set; }

    public BankAccount(double initialBalance)
    {
        Balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
            throw new ArgumentException("Invalid amount!");
        if (amount > Balance)
            throw new InsufficientFundsException("Insufficient balance!");

        Balance -= amount;
        Console.WriteLine($"Withdrawal successful, new balance: {Balance}");
    }
}

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

    static void ProcessArrayDivision(int[] array, int index, int divisor)
    {
        try
        {
            try
            {
                int value = array[index];
                try
                {
                    Console.WriteLine("Result: " + (value / divisor));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter initial bank balance: ");
            double initialBalance = Convert.ToDouble(Console.ReadLine());
            BankAccount account = new BankAccount(initialBalance);

            Console.Write("Enter withdrawal amount: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(withdrawAmount);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Invalid input: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numeric values.");
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

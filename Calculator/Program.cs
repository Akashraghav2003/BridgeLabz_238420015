using System;

namespace Calculators
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Enter the value of num1: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    throw new FormatException();
                }

                Console.Write("Enter the value of num2: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    throw new FormatException();
                }

                Calculator calculator = new Calculator(num1, num2);
                double result;
                result = calculator.Add();

                Console.WriteLine("Number after add: " + result);

                result = calculator.Substract();
                Console.WriteLine("Number after substract: " + result);

                result = calculator.Multiply();
                Console.WriteLine("Number after Multiply: " + result);

                result = calculator.Divide();
                Console.WriteLine("Number after divide: " + result);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Numerator should not be Zero. ");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter Double or intiger for operation.");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Enter some value.");
            }
        }
    }
}
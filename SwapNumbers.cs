//Create a program to swap two numbers

using System; // Import System namespace

namespace Assignment2{
	
    class SwapNumbers{
		
        static void Main()
        {
            // enter the first number from user
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine()); // Convert input to integer

            //  enter the second number from user
            Console.Write("Enter second number: ");
            int number2 = Convert.ToInt64(Console.ReadLine()); // Convert input to integer

            // Swap numbers using a temporary variable
            int temp = number1;
            number1 = number2;
            number2 = temp;

            // Display the swapped numbers
            Console.WriteLine("The swapped numbers are " + number1 + " and " + number2);
        }
    }
}

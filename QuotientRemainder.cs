using System; // Import System namespace for input/output operations

namespace Assignment2{
	
    class QuotientRemainder{
		
        static void Main(){
			
            // take input from user for the first number
            Console.Write("Enter the first number: ");
            int number1 = int.Parse(Console.ReadLine()); // Convert input to integer

            // take input from user for the second number
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

            // Calculate quotient using division operator
            int quotient = number1 / number2;

            // Calculate remainder using modulus operator
            int remainder = number1 % number2;

            // Display the result
            Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}");
        }
    }
}


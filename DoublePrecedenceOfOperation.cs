using System; // Import System namespace

namespace Assignment2{
	
    class DoublePrecedenceOfOperation{
		
        static void Main(){
            // take input from user
            Console.Write("Enter value for a: ");
            double a = double.Parse(Console.ReadLine()); // Convert input to double

            Console.Write("Enter value for b: ");
            double b = Convert.ToDouble(Console.ReadLine()); // Convert input to double

            Console.Write("Enter value for c: ");
            double c = Convert.ToDouble(Console.ReadLine()); // Convert input to double

            // Perform double operations based on precedence
            double result1 = a + b * c; // Multiplication first, then addition
            double result2 = a * b + c; // Multiplication first, then addition
            double result3 = c + a / b; // Division first, then addition
            double result4 = a % b + c; // Modulus first, then addition

            // Display the results
            Console.WriteLine("The results of Int Operations are " + result1 + ", " + result2 + ", " + result3 + ", and " + result4);
        }
    }
}

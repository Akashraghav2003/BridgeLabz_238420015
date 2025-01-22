//Write an IntOperation program by taking a, b, and c as input values and print the following integer operations: a + b * c, a * b + c, c + a / b, and a % b + c. 

using System; // Import System namespace

namespace Assignment2{
	
    class PrecedenceOfOperation{
		
        static void Main(String[] args){
			
            // Take input from user
            Console.Write("Enter value for a: ");
            int a = int.Parse(Console.ReadLine()); // Convert input to integer

            Console.Write("Enter value for b: ");
            int b = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

            Console.Write("Enter value for c: ");
            int c = Convert.ToInt32(Console.ReadLine()); // Convert input to integer

            // Perform integer operations based on precedence
            int result1 = a + b * c; // Multiplication has higher precedence than addition
            int result2 = a * b + c; // Multiplication first, then addition
            int result3 = c + a / b; // Division first, then addition
            int result4 = a % b + c; // Modulus first, then addition

            // Display the results using concatenation
            Console.WriteLine("The results of Int Operations are " + result1 + ", " + result2 + ", " + result3 + ", and " + result4);
        }
    }
}

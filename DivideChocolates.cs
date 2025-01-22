//Create a program to divide N number of chocolates among M children.

using System; // Import System namespace

namespace Assignment2
{
    class DivideChocolates
    {
        static void Main()
        {
            // Take user input for number of chocolates and children
            Console.Write("Enter the total number of chocolates: ");
            int numberOfChocolates = int.Parse(Console.ReadLine()); // Convert input to integer

            Console.Write("Enter the number of children: ");
            int numberOfChildren = int.Parse(Console.ReadLine()); // Convert input to integer

            // Calculate chocolates each child gets and the remaining chocolates
            int chocolatesPerChild = numberOfChocolates / numberOfChildren;
            int remainingChocolates = numberOfChocolates % numberOfChildren;

            // Display the result
            Console.WriteLine("The number of chocolates each child gets is " + chocolatesPerChild +" and the number of remaining chocolates is " + remainingChocolates + ".");
        }
    }
}

//An athlete runs in a triangular park with sides provided as input by the user in meters. If the athlete wants to complete a 5 km run, then how many rounds must the athlete complete?

using System; // Import System namespace

namespace Assignment2{
    class AthleteRun{
        static void Main(){
            // Take user input for the sides of the triangular park
            Console.Write("Enter side1 (in meters): ");
            double side1 = double.Parse(Console.ReadLine()); // Convert input to double

            Console.Write("Enter side2 (in meters): ");
            double side2 = double.Parse(Console.ReadLine()); // Convert input to double

            Console.Write("Enter side3 (in meters): ");
            double side3 = double.Parse(Console.ReadLine()); // Convert input to double

            // Calculate the perimeter of the triangle
            double perimeter = side1 + side2 + side3;

            // Calculate the number of rounds required to complete 5 km
            double distanceToRun = 5000; // Convert 5 km to meters
            int rounds = (int)Math.Ceiling(distanceToRun / perimeter); // Rounds required

            // Display the result
            Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km.");
        }
    }
}

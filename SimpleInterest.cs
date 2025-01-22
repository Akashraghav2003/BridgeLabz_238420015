//Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.

using System; // Import System namespace

namespace Assignment2{
	
    class SimpleInterest{
		
        static void Main(){
            // Take user input for principal, rate, and time
            Console.Write("Enter the principal amount: ");
            double principal = double.Parse(Console.ReadLine()); // Convert input to double

            Console.Write("Enter the rate of interest (in %): ");
            double rate = double.Parse(Console.ReadLine()); // Convert input to double

            Console.Write("Enter the time (in years): ");
            double time = double.Parse(Console.ReadLine()); // Convert input to double

            // Calculate simple interest
            double simpleInterest = (principal * rate * time) / 100;

            // Display the result
            Console.WriteLine("The Simple Interest is " + simpleInterest +" for Principal " + principa+", Rate of Interest " + rate + "%, and Time " + time + " years.");
        }
    }
}

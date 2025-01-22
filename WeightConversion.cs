//Create a program to convert weight in pounds to kilograms.



using System; // Import System namespace to take input and output

namespace Assignment2{
	
    class WeightConversion{
		
        static void Main(){
            // Take user input for weight in pounds
            Console.Write("Enter weight in pounds: ");
            double pounds = double.Parse(Console.ReadLine()); // Convert input to double

            // Convert pounds to kilograms
            double kilograms = pounds / 2.2; // 1 pound = 2.2 kg

            // Display the result
            Console.WriteLine("The weight of the person in pounds is " + pounds +" and in kilograms is " + kilograms + ".");
        }
    }
}

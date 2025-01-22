//Write a TemperatureConversion program, given the temperature in Celsius as input that outputs the temperature in Fahrenheit

using System; // Import System namespace

namespace Assignment2{
	
    class TemperatureConversion{
		
        static void Main(){
            // Take input from user of  temperature in Celsius
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine()); // Convert input to double

            // Convert Celsius to Fahrenheit using formula
            double fahrenheit = (celsius * 9 / 5) + 32;

            // Display the result
            Console.WriteLine(celsius + " Celsius is " + fahrenheit + " Fahrenheit");
        }
    }
}

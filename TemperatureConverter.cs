// Temperature Converter:
// Write a program that converts temperatures between Fahrenheit and Celsius.
// ● The program should have separate functions for converting from Fahrenheit to
// Celsius and from Celsius to Fahrenheit.
using System;

class TemperatureConverter{
	
	// Method to take a temperature input from the user
	public static double Input(){
		Console.WriteLine("Enter the temperature: ");
		return Convert.ToDouble(Console.ReadLine());
	}

	// Convert Fahrenheit to Celsius
	public static double ConvertFahrenheitToCelsius(double fahrenheit) {
		return (fahrenheit - 32) * 5 / 9;
	}

	// Convert Celsius to Fahrenheit
	public static double ConvertCelsiusToFahrenheit(double celsius) {
		return (celsius * 9 / 5) + 32;
	}

	// Display the conversion results
	static void Display(){
		Console.WriteLine("Press 'F' to convert Fahrenheit to Celsius or 'C' to convert Celsius to Fahrenheit: ");
		char temp = Console.ReadLine()[0];

		if(temp == 'F'){
			double input = Input();
			Console.WriteLine("Temperature in Celsius: " + ConvertFahrenheitToCelsius(input));
		}else if(temp == 'C'){
			double input = Input();
			Console.WriteLine("Temperature in Fahrenheit: " + ConvertCelsiusToFahrenheit(input));
		}else{
			Console.WriteLine("Invalid input! Please press 'F' or 'C'.");
		}
	}

	public static void Main(String[] args){
		Display();
	}
}

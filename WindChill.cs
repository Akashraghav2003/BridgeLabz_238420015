//Write a program calculate the wind chill temperature given the temperature and wind speed

using System;

namespace Assignment4
{
	class WindChillCalculator
	{
		// Method to calculate the wind chill using the formula
		public double CalculateWindChill(double temperature, double windSpeed)
		{
			return 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
		}

		public static void Main()
		{
			// Prompt the user to enter temperature and wind speed
			Console.WriteLine("Enter temperature and wind speed: ");
			double temperature = Convert.ToDouble(Console.ReadLine());
			double windSpeed = Convert.ToDouble(Console.ReadLine());

			// Create an instance of the class
			WindChillCalculator obj = new WindChillCalculator();

			// Calculate the wind chill
			double result = obj.CalculateWindChill(temperature, windSpeed);

			// Display the wind chill
			Console.WriteLine("Wind chill: " + result);
		}
	}
}

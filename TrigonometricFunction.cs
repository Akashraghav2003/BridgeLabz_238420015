//Write a program to calculate various trigonometric functions using Math class given an angle in degrees

using System;

namespace Assignment4
{
	class TrigonometricFunction
	{
		// Method to calculate the radian, sine, cosine, and tangent of an angle in degrees
		public static double[] FindTrigonometricFunction(double degree)
		{
			// Convert the angle from degrees to radians
			double radian = degree * Math.PI / 180;

			// Calculate the sine of the angle
			double sine = Math.Sin(radian);

			// Calculate the cosine of the angle
			double cosine = Math.Cos(radian);

			// Calculate the tangent of the angle
			double tangent = Math.Tan(radian);

			// Return all calculated values as an array
			return new double[] { radian, sine, cosine, tangent };
		}

		public static void Main()
		{
			// Prompt the user to enter an angle in degrees
			Console.WriteLine("Enter the angle in degree: ");
			double degree = Convert.ToInt32(Console.ReadLine()); // Read and convert the input to double

			// Call the method to calculate trigonometric values
			double[] result = FindTrigonometricFunction(degree);

			// Display the results
			Console.WriteLine("The radian angle is: " + result[0]); // Display the angle in radians
			Console.WriteLine("The sine is: " + result[1]);         // Display the sine of the angle
			Console.WriteLine("The cosine is: " + result[2]);       // Display the cosine of the angle
			Console.WriteLine("The tangent is: " + result[3]);      // Display the tangent of the angle
		}
	}
}

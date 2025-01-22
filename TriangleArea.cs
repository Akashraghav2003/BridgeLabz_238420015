//Write a program that takes the base and height to find the area of a triangle in square inches and square centimeters

using System;
namespace Assignment{
	
	class TriangleArea{
		
		static void Main(){
			
			// Taking input in centimeters
			Console.Write("Enter the base of the triangle in centimeters: ");
			double baseInCentimeters = Convert.ToDouble(Console.ReadLine());

			//Taking input of height in Centimeters
			Console.Write("Enter the height of the triangle in centimeters: ");
			double heightInCentimeters = Convert.ToDouble(Console.ReadLine());

			// Compute the area in square centimeters
			double areaInCentimetersSquare = 0.5 * baseInCentimeters * heightInCentimeters;

			// Convert to square inches (1 cm = 0.393701 inches)
			double baseInches = baseInCentimeters * 0.393701;
			double heightInches = heightInCentimeters * 0.393701;
			double areaInInches = 0.5 * baseInches * heightInches;

			// Display the results
			Console.WriteLine("Your area in cm square is "+areaInCentimetersSquare+" while in inches square "+areaInInches);
		}
	}
}

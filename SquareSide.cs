// Write a program to find the side of the square whose perimeter you read from user


using System;

namespace Assignment{
	
	class SquareSide{
		
		static void Main(string[] args){
			
			//Take input from user as perimeter of rectangle
			Console.WriteLine("Enter the perimeter of the square: ");
			double perimeter = Convert.ToDouble(Console.ReadLine());

			// Calculate the one side length of square
			double sideLength = perimeter / 4.0;

			// Output of program 
			Console.WriteLine("The length of the side is " + sideLength + " whose perimeter is " + perimeter);
		}
	}
}
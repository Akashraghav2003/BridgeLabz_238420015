//Write a program that takes your height in centimeters and converts it into feet and inches


using System;

namespace Assignment{

	class HeightConverter
	{
		static void Main()
		{
			// taking input from user in centemiters
			Console.Write("Enter your height in centimeters: ");
			double heightInCm = Convert.ToDouble(Console.ReadLine());

			// Conversion factors
			double totalInches = heightInCm / 2.54;
			
			// Get the whole number of feet
			int feet = (int)(totalInches / 12);  
			
			// Get the remaining inches
			double inches = totalInches % 12;    

			// Display the height in feet and inches
			Console.WriteLine("Your height in cm is "+ heightInCm+", while in feet is "+feet+" and inches is "+inches);
		}
	}
}
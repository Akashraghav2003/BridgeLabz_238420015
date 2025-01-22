//Create a program to convert distance in kilometers to miles

using System;

namespace Assignment{
	class KMToMiles{
		static void Main (String [] args) {
			Console.Write("Write Distance in KM: ");
			double km = Convert.ToDouble(Console.ReadLine());
			
			double miles = km /1.6;
			
			Console.WriteLine("The total Miles is "+miles+" mile for given "+ km +"km");
		}
	}
}
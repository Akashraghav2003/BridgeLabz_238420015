// Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following. 
// Please define static methods for all the UnitConvertor class methods.




using System;

namespace Assignment4{

	class UnitConverter {

		// Method to convert kilometers to miles
		public static double ConvertKmToMiles(double km) {
			double km2miles = 0.621371;
			return km * km2miles;
		}

		// Method to convert miles to kilometers
		public static double ConvertMilesToKm(double miles) {
			double miles2km = 1.60934;
			return miles * miles2km;
		}

		// Method to convert meters to feet
		public static double ConvertMetersToFeet(double meters) {
			double meters2feet = 3.28084;
			return meters * meters2feet;
		}

		// Method to convert feet to meters
		public static double ConvertFeetToMeters(double feet) {
			double feet2meters = 0.3048;
			return feet * feet2meters;
		}

		static void Main(string[] args) {
			// Input for kilometers
			Console.Write("Enter kilometers: ");
			double km = Convert.ToDouble(Console.ReadLine());

			// Input for miles
			Console.Write("Enter miles: ");
			double miles = Convert.ToDouble(Console.ReadLine());

			// Input for meters
			Console.Write("Enter meters: ");
			double meters = Convert.ToDouble(Console.ReadLine());

			// Input for feet
			Console.Write("Enter feet: ");
			double feet = Convert.ToDouble(Console.ReadLine());

			// Calculations
			double kmToMiles = ConvertKmToMiles(km);
			double milesToKm = ConvertMilesToKm(miles);
			double metersToFeet = ConvertMetersToFeet(meters);
			double feetToMeters = ConvertFeetToMeters(feet);

			// Displaying result
			Console.WriteLine("Kilometers to Miles: " + km + " km = " + kmToMiles + " miles");
			Console.WriteLine("Miles to Kilometers: " + miles + " miles = " + milesToKm + " km");
			Console.WriteLine("Meters to Feet: " + meters + " meters = " + metersToFeet + " feet");
			Console.WriteLine("Feet to Meters: " + feet + " feet = " + feetToMeters + " meters");
		}
	}

}

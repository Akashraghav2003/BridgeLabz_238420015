// Write a program that takes a year as input and outputs the Year is a Leap Year or not 
// Hint => 
// a.The LeapYear program only works for year >= 1582, corresponding to a year in the Gregorian calendar. 
// b.Also Leap year is divisible by 4 and not divisible by 100 or divisible by 400
// c.Write a method to check for Leap Year using the conditions a and b


using System;

namespace Assignment4{

	class LeapYearChecker {

		// Method to check if a year is a leap year
		public static bool IsLeapYear(int year) {
			// Condition to check if the year is in the Gregorian calendar
			if (year < 1582) {
				Console.WriteLine("The Leap Year program only works for years >= 1582 (Gregorian calendar).");
				return false;
			}

			// Leap year conditions
			if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) {
				return true;
			}
			return false;
		}

		static void Main(string[] args) {
			// Taking user input for the year
			Console.Write("Enter a year (>= 1582): ");
			int year = Convert.ToInt32(Console.ReadLine());

			// Call the method to check if it's a leap year
			bool result = IsLeapYear(year);

			// Display the result
			if (result) {
				Console.WriteLine(year +" is a Leap Year.");
			} else {
				Console.WriteLine(year + " is NOT a Leap Year.");
			}
		}
	}
}

//Write a LeapYear program that takes a year as input and outputs the Year is a Leap Year or not a Leap Year. 

using System;

namespace Assignment{
	
    class LeapYear2{
		
        static void Main(){
			
			//take the year from user
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine()); // Changed to Convert.ToInt32 for correct type

				// Check wheather given year is grater than 1581 or not
			if (year < 1582)
			{
				Console.WriteLine("Year should be >= 1582");
			}//check year is leap year or not
			else if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
			{
				Console.WriteLine($"{year} is a Leap Year");
			}
			else{ // Display the result
				Console.WriteLine($"{year} is not a Leap Year");
			}
        }
    }
}

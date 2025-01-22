//Create a program to convert the distance of 10.8 kilometers to miles.
//Hint: 1 km = 0.6 miles
//I/P => NONE
//O/P => The distance ___ km in miles is ___

using System;

namespace Assignment{
	
	class DistanceConverter {
		static void Main (){
			double disInKM = 10.8;
			double disInMiles = disInKM * 0.6;
			Console.WriteLine("The distance "+disInKM+" in miles is "+disInMiles);
		}
	}
}
//Write a Program to compute the volume of Earth in km^3 and miles^3
//Hint: Volume of a Sphere is (4/3) * pi * r^3 and radius of earth is 6378 km

using System;

namespace Assignment{
	
	class EarthVolume{
		
		static void Main (){
			//radius of earth in KM
			int radiusInKM = 6378;
			//radius change in miles
			double radiusInMiles = radiusInKM/1.609;

			//compute the volume in km^3 and miles^3
			double volumeInKM = (4.0/3.0)*3.14*radiusInKM*radiusInKM*radiusInKM;
			double volumeInMiles = (4.0/3.0)*3.14*radiusInMiles*radiusInMiles*radiusInMiles;
			
			//display the result
			Console.WriteLine("The vol of earth in cubic kilometer is "+volumeInKM+ " and cubic miles "+volumeInMiles);
		}
	}
}
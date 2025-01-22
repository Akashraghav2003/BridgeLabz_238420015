// Write a program to find the distance in yards and miles for the distance provided by the user in feet

using System;

class DistanceConverterFeet{
    static void Main(string[] args){
        // display the message to the user for distance input in feet
        Console.Write("Enter the distance in feet: ");
		//takin input in feet
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());

        // Conversion factors
		// 1 yard = 3 feet
		 // 1 mile = 1760 yards
        double distanceInYards = distanceInFeet / 3; 
        double distanceInMiles = distanceInYards / 1760;

        // Display the result 
        Console.WriteLine("The distance in feet is " + distanceInFeet + ", which is equivalent to " + distanceInYards+ " yards and " + distanceInMiles + " miles.");
    }
}
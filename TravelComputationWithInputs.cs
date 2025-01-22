//Rewrite the Sample Program 2 with user inputs.Problem Statement: Eric travels from Chennai to Bangalore via Vellore. The distance from Chennai to Vellore is 156.6 km and the time taken is 4 hours 4 minutes. The distance from Vellore to Bangalore is 211.8 km and the time taken is 4 hours 25 minutes. Compute the total distance and total time from Chennai to Bangalore.

using System; // Import System namespace

namespace Assignment2 {         // Namespace for assignments

    class TravelComputationWithInputs{
		
        static void Main(string[] args){
            //take input from user 
            Console.Write("Enter the traveler's name: ");
            string name = Console.ReadLine(); // Traveler's name

            Console.Write("Enter the starting city: ");
            string fromCity = Console.ReadLine(); // Starting city

            Console.Write("Enter the via city: ");
            string viaCity = Console.ReadLine(); // Via city

            Console.Write("Enter the destination city: ");
            string toCity = Console.ReadLine(); // Destination city

            Console.Write("Enter the distance from " + fromCity + " to " + viaCity + " in miles: ");
            double distanceFromToVia = double.Parse(Console.ReadLine()); // Distance from start to via city

            Console.Write("Enter the distance from " + viaCity + " to " + toCity + " in miles: ");
            double distanceViaToFinalCity = double.Parse(Console.ReadLine()); // Distance from via city to destination

            Console.Write("Enter the total time taken from " + fromCity + " to " + toCity + " in minutes: ");
            int totalTime = int.Parse(Console.ReadLine()); // Total travel time in minutes

            // Compute the total distance
            double totalDistance = distanceFromToVia + distanceViaToFinalCity;

            // Convert total time into hours and minutes for better readability
            int totalHours = totalTime / 60; // Total hours
            int totalMinutes = totalTime % 60; // Remaining minutes

            // Print the travel details
            Console.WriteLine($"The results of the trip are: Traveler: {name}, Route: {fromCity} -> {viaCity} -> {toCity}, Total Distance: {totalDistance} miles, Total Time Taken: {totalHours} hours {totalMinutes} minutes");

        }
    }
}

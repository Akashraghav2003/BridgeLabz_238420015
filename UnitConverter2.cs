 // Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following. 
 // Please define static methods for all the UnitConvertor class methods.


using System;

namespace Assignment4 {

    class UnitConverter2 {

        // Method to convert yards to feet
        public static double ConvertYardsToFeet(double yards) {
            double yards2feet = 3;
            return yards * yards2feet;
        }

        // Method to convert feet to yards
        public static double ConvertFeetToYards(double feet) {
            double feet2yards = 0.333333;
            return feet * feet2yards;
        }

        // Method to convert meters to inches
        public static double ConvertMetersToInches(double meters) {
            double meters2inches = 39.3701;
            return meters * meters2inches;
        }

        // Method to convert inches to meters
        public static double ConvertInchesToMeters(double inches) {
            double inches2meters = 0.0254;
            return inches * inches2meters;
        }

        // Method to convert inches to centimeters
        public static double ConvertInchesToCentimeters(double inches) {
            double inches2cm = 2.54;
            return inches * inches2cm;
        }

        static void Main(string[] args) {
            // Input for yards
            Console.Write("Enter yards: ");
            double yards = Convert.ToDouble(Console.ReadLine());

            // Input for feet
            Console.Write("Enter feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());

            // Input for meters
            Console.Write("Enter meters: ");
            double meters = Convert.ToDouble(Console.ReadLine());

            // Input for inches
            Console.Write("Enter inches: ");
            double inches = Convert.ToDouble(Console.ReadLine());

            // Calculations
            double yardsToFeet = ConvertYardsToFeet(yards);
            double feetToYards = ConvertFeetToYards(feet);
            double metersToInches = ConvertMetersToInches(meters);
            double inchesToMeters = ConvertInchesToMeters(inches);
            double inchesToCentimeters = ConvertInchesToCentimeters(inches);

            // Displaying results
            Console.WriteLine("Results:");
            Console.WriteLine("Yards to Feet: " + yards + " yards = " + yardsToFeet + " feet");
            Console.WriteLine("Feet to Yards: " + feet + " feet = " + feetToYards + " yards");
            Console.WriteLine("Meters to Inches: " + meters + " meters = " + metersToInches + " inches");
            Console.WriteLine("Inches to Meters: " + inches + " inches = " + inchesToMeters + " meters");
            Console.WriteLine("Inches to Centimeters: " + inches + " inches = " + inchesToCentimeters + " centimeters");
        }
    }
}

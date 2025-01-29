 // Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following.  
 // Please define static methods for all the UnitConvertor class methods.
 
 
 using System;

namespace Assignment4 {

    class UnitConverter3 {

        // Method to convert Fahrenheit to Celsius
        public static double ConvertFahrenheitToCelsius(double fahrenheit) {
            return (fahrenheit - 32) * 5 / 9;
        }

        // Method to convert Celsius to Fahrenheit
        public static double ConvertCelsiusToFahrenheit(double celsius) {
            return (celsius * 9 / 5) + 32;
        }

        // Method to convert pounds to kilograms
        public static double ConvertPoundsToKilograms(double pounds) {
            double pounds2kilograms = 0.453592;
            return pounds * pounds2kilograms;
        }

        // Method to convert kilograms to pounds
        public static double ConvertKilogramsToPounds(double kilograms) {
            double kilograms2pounds = 2.20462;
            return kilograms * kilograms2pounds;
        }

        // Method to convert gallons to liters
        public static double ConvertGallonsToLiters(double gallons) {
            double gallons2liters = 3.78541;
            return gallons * gallons2liters;
        }

        // Method to convert liters to gallons
        public static double ConvertLitersToGallons(double liters) {
            double liters2gallons = 0.264172;
            return liters * liters2gallons;
        }

        static void Main(string[] args) {
            // Input for Fahrenheit
            Console.Write("Enter Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Input for Celsius
            Console.Write("Enter Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Input for pounds
            Console.Write("Enter pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());

            // Input for kilograms
            Console.Write("Enter kilograms: ");
            double kilograms = Convert.ToDouble(Console.ReadLine());

            // Input for gallons
            Console.Write("Enter gallons: ");
            double gallons = Convert.ToDouble(Console.ReadLine());

            // Input for liters
            Console.Write("Enter liters: ");
            double liters = Convert.ToDouble(Console.ReadLine());

            // Calculations
            double fahrenheitToCelsius = ConvertFahrenheitToCelsius(fahrenheit);
            double celsiusToFahrenheit = ConvertCelsiusToFahrenheit(celsius);
            double poundsToKilograms = ConvertPoundsToKilograms(pounds);
            double kilogramsToPounds = ConvertKilogramsToPounds(kilograms);
            double gallonsToLiters = ConvertGallonsToLiters(gallons);
            double litersToGallons = ConvertLitersToGallons(liters);

            // Displaying results
            Console.WriteLine("Results:");
            Console.WriteLine("Fahrenheit to Celsius: " + fahrenheit + " °F = " + fahrenheitToCelsius + " °C");
            Console.WriteLine("Celsius to Fahrenheit: " + celsius + " °C = " + celsiusToFahrenheit + " °F");
            Console.WriteLine("Pounds to Kilograms: " + pounds + " lbs = " + poundsToKilograms + " kg");
            Console.WriteLine("Kilograms to Pounds: " + kilograms + " kg = " + kilogramsToPounds + " lbs");
            Console.WriteLine("Gallons to Liters: " + gallons + " gal = " + gallonsToLiters + " L");
            Console.WriteLine("Liters to Gallons: " + liters + " L = " + litersToGallons + " gal");
        }
    }
}

using System;

class KilometerToMiles
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the distance in kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());

        double miles = kilometers * 0.621371;

        Console.WriteLine("The distance in miles is: " + miles);
    }
}

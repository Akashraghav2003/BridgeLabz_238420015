 // Write a program to find the 3 points that are collinear using the slope formulae and area of triangle formulae. 
 // check  A (2, 4), B (4, 6) and C (6, 8) are Collinear for sampling.




using System;

namespace Assignment4
{
    public class CollinearPoints
    {
        // Method to check if the points are collinear using the slope formula
        public static bool ArePointsCollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // Calculate the slopes
            double slopeAB = (y2 - y1) / (x2 - x1);
            double slopeBC = (y3 - y2) / (x3 - x2);
            double slopeAC = (y3 - y1) / (x3 - x1);

            // Points are collinear if all slopes are equal
            if (slopeAB == slopeBC && slopeAB == slopeAC)
                return true;
            else
                return false;
        }

        // Method to check if the points are collinear using the area of the triangle formula
        public static bool ArePointsCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // Calculate the area of the triangle
            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            // Points are collinear if the area is 0
            if (area == 0)
                return true;
            else
                return false;
        }

        // Main method to take inputs and display the results
        public static void Main()
        {
            // Input for three points (x1, y1), (x2, y2), (x3, y3)
            Console.WriteLine("Enter the coordinates of point A (x1, y1): ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of point B (x2, y2): ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of point C (x3, y3): ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());

            // Check if points are collinear using the slope formula
            bool isCollinearBySlope = ArePointsCollinearUsingSlope(x1, y1, x2, y2, x3, y3);
            if (isCollinearBySlope)
                Console.WriteLine("The points are collinear using the slope formula.");
            else
                Console.WriteLine("The points are not collinear using the slope formula.");

            // Check if points are collinear using the area of the triangle formula
            bool isCollinearByArea = ArePointsCollinearUsingArea(x1, y1, x2, y2, x3, y3);
            if (isCollinearByArea)
                Console.WriteLine("The points are collinear using the area formula.");
            else
                Console.WriteLine("The points are not collinear using the area formula.");
        }
    }
}

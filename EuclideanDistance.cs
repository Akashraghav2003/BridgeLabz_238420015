  // Write a program Euclidean distance between two points as well as the equation of the line using those two points.
  // Use Math functions Math.Pow() and Math.Sqrt()

using System;

namespace Assignment4
{
    public class EuclideanDistance
    {
        // Method to calculate Euclidean distance between two points (x1, y1) and (x2, y2)
        public static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2) {
            // Euclidean distance formula
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }

        // Method to find the equation of the line given two points (x1, y1) and (x2, y2)
        public static double[] CalculateLineEquation(double x1, double y1, double x2, double y2) {
            double[] equation = new double[2]; // [slope, y-intercept]

            // Check if x1 == x2 to avoid division by zero (vertical line case)
            if (x1 == x2) {
                Console.WriteLine("The line is vertical. Equation is x = " + x1);
                return equation;
            }

            // Calculate the slope (m)
            double slope = (y2 - y1) / (x2 - x1);

            // Calculate the y-intercept (b)
            double yIntercept = y1 - slope * x1;

            // Store the slope and y-intercept in the array
            equation[0] = slope;
            equation[1] = yIntercept;

            return equation;
        }

        // Main method to take inputs and display the results
        public static void Main() {
            // Input for the two points (x1, y1) and (x2, y2)
            Console.WriteLine("Enter the coordinates of the first point (x1, y1): ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the coordinates of the second point (x2, y2): ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Calculate the Euclidean distance
            double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
            Console.WriteLine("The Euclidean distance between the points is: " + distance);

            // Calculate the equation of the line
            double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);

            if (x1 != x2) {
                Console.WriteLine("The equation of the line is: y = " + lineEquation[0] + " * x + " + lineEquation[1]);
            }
        }
    }
}

// Write a program Quadratic to find the roots of the equation ax2+ bx + c. 
// Use Math functions Math.pow() and Math.sqrt()


using System;

namespace Assignment4{

	class QuadraticRoot {
		// Method to find the roots of the quadratic equation
		public static void FindRoots(double a, double b, double c) {
			// Calculate the discriminant (delta)
			double delta = Math.Pow(b, 2) - 4 * a * c;

			// Check the discriminant value and calculate roots accordingly
			if (delta > 0) {
				// Two real and distinct roots
				double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
				double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
				Console.WriteLine("The roots are real and distinct.");
				Console.WriteLine("Root 1: " + root1);
				Console.WriteLine("Root 2: " + root2);
			} else if (delta == 0) {
				// One real root
				double root = -b / (2 * a);
				Console.WriteLine("The root is real and repeated.");
				Console.WriteLine("Root: " + root);
			} else {
				// No real roots (delta is negative)
				Console.WriteLine("The equation has no real roots.");
			}
		}

		static void Main() {
			// Take input values for a, b, and c
			Console.Write("Enter coefficient a: ");
			double a = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter coefficient b: ");
			double b = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter coefficient c: ");
			double c = Convert.ToDouble(Console.ReadLine());

			// Call the method to find the roots of the quadratic equation
			FindRoots(a, b, c);
		}
	}

}

//Create a program to find the maximum number of handshakes among N number of students

using System;

namespace Assignment{
	
	class NoOfHandshake{

		static void Main(){
			
			Console.Write("Enter the number of students: ");
			//user gives the input of student number
			int numberOfStudents = Convert.ToInt32(Console.ReadLine());

			// Calculate the maximum number of handshakes using the formula: (n * (n - 1)) / 2
			
			int handShakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

			// Display the result
			Console.WriteLine("The maximum number of possible handshakes is: " + handShakes);
		}
	}
}
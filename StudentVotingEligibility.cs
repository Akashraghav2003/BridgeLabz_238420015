// Write a program to take user input for the age of all 10 students in a class and 
// check whether the student can vote depending on his/her age is greater or equal to 18.



using System;

namespace ArrayLevel1{

	class StudentVotingEligibility
	{
		static void Main(string[] args)
		{
			int[] ages = new int[10]; // Array to store the ages of 10 students

			Console.WriteLine("Enter the ages of 10 students:");

			// Input ages for all students
			for (int i = 0; i < ages.Length; i++) // Loop through each student
			{
				Console.WriteLine("Enter age for student " + (i + 1) + ":");
				ages[i] = int.Parse(Console.ReadLine());
			}

			Console.WriteLine("Voting Eligibility Results:");

			// Determine voting eligibility for each student based on their age
			for (int i = 0; i < ages.Length; i++)
			{
				if (ages[i] < 0) // Check if an invalid (negative) age is entered
				{
					Console.WriteLine("Invalid age entered for student " + (i + 1));
				}
				else if (ages[i] >= 18) // Check if the student is eligible to vote (18 or older)
				{
					Console.WriteLine("The student with the age " + ages[i] + " is eligible to vote.");
				}
				else // If the student is under 18, they cannot vote
				{
					Console.WriteLine("The student with the age " + ages[i] + " is not eligible to vote.");
				}
			}
		}
	}

}

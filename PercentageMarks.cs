//Create a program to take input marks of students in 3 subjects physics, chemistry, and maths. Compute the percentage and then calculate the grade 

using System;

namespace ArrayLevel2
{
    class PercentageMarks
    {
        static void Main()
        {
            // Input the number of students
            Console.Write("Enter the number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // Arrays to store marks, percentages, and grades
            int[,] marks = new int[numberOfStudents, 3]; // [students, 3 subjects: Physics, Chemistry, Math]
            double[] percentages = new double[numberOfStudents];
            string[] grades = new string[numberOfStudents];

            // Input marks for each student
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("\nEnter marks for Student " + (i + 1) + ":");

                for (int j = 0; j < 3; j++)
                {
                    string subject = (j == 0) ? "Physics" : (j == 1) ? "Chemistry" : "Math";
                    Console.Write($"Enter marks in {subject}: ");
                    marks[i, j] = Convert.ToInt32(Console.ReadLine());

                    // Validate positive marks
                    while (marks[i, j] < 0)
                    {
                        Console.WriteLine("Marks cannot be negative. Please enter a positive value.");
                        Console.Write($"Enter marks in {subject}: ");
                        marks[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // Calculate percentage
                percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

                // Determine grade based on percentage
                if (percentages[i] >= 80)
                {
                    grades[i] = "Level 4: Above agency-normalized standards.";
                }
                else if (percentages[i] >= 70)
                {
                    grades[i] = "Level 3: At agency-normalized standards.";
                }
                else if (percentages[i] >= 60)
                {
                    grades[i] = "Level 2: Approaching agency-normalized standards.";
                }
                else if (percentages[i] >= 50)
                {
                    grades[i] = "Level 1: Below agency-normalized standards.";
                }
                else if (percentages[i] >= 40)
                {
                    grades[i] = "Level 1: Too below agency-normalized standards.";
                }
                else
                {
                    grades[i] = "Remedial standards.";
                }
            }

            // Display results for all students
            Console.WriteLine("\nResults:");
            Console.WriteLine("Student   Physics   Chemistry   Math   Percentage   Grade");
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine(
                    (i + 1) + "        " +
                    marks[i, 0] + "         " +
                    marks[i, 1] + "          " +
                    marks[i, 2] + "     " +
                    percentages[i].ToString("F2") + "        " +
                    grades[i]
                );
            }
        }
    }
}


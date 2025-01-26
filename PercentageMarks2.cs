// Rewrite the above program to store the marks of the students in physics, chemistry, and maths in a 2D array and then compute the percentage and grade
// Hint => 
// All the steps are the same as the problem 8 except the marks are stored in a 2D array
// Use the 2D array to calculate the percentages, and grades of the students



using System;

namespace Assignment
{
    class PercentageMarks2
    {
        static void Main()
        {
            // Input the number of students
            Console.Write("Enter the number of students: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            // 2D array to store marks for Physics, Chemistry, and Math
            int[,] marks = new int[numberOfStudents, 3]; // Rows: Students, Columns: Subjects
            double[] percentages = new double[numberOfStudents]; // To store calculated percentages
            string[] grades = new string[numberOfStudents]; // To store grades for each student

            // Input marks for each student
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine("\nEnter marks for Student " + (i + 1) + ":");

                for (int j = 0; j < 3; j++)
                {
                    // Determine the subject based on column index
                    string subject = (j == 0) ? "Physics" : (j == 1) ? "Chemistry" : "Math";

                    // Input and validate marks for the subject
                    Console.Write($"Enter marks in {subject}: ");
                    marks[i, j] = Convert.ToInt32(Console.ReadLine());

                    while (marks[i, j] < 0)
                    {
                        Console.WriteLine("Marks cannot be negative. Please enter a positive value.");
                        Console.Write($"Enter marks in {subject}: ");
                        marks[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // Calculate percentage for the student
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

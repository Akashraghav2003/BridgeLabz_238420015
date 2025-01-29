// Create a program to take input marks of students in 3 subjects physics, chemistry, and maths. 
// Compute the total, average, and the percentage score 




using System;

namespace Assignment4 {
    public class AverageTotalPercentageOfMarks {
        // Method to generate random PCM scores for students
        public static int[,] GenerateScores(int numberOfStudents) {
            Random random = new Random();
            int[,] scores = new int[numberOfStudents, 3]; // 3 subjects: Physics, Chemistry, Math

            for (int i = 0; i < numberOfStudents; i++) {
                scores[i, 0] = random.Next(10, 100); // Physics
                scores[i, 1] = random.Next(10, 100); // Chemistry
                scores[i, 2] = random.Next(10, 100); // Math
            }

            return scores;
        }

        // Method to calculate total, average, and percentage for students
        public static double[,] CalculateResults(int[,] scores) {
            int numberOfStudents = scores.GetLength(0);
            double[,] results = new double[numberOfStudents, 3]; // [Total, Average, Percentage]

            for (int i = 0; i < numberOfStudents; i++) {
                int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
                double average = total / 3.0;
                double percentage = (total / 300.0) * 100;

                results[i, 0] = total;
                results[i, 1] = Math.Round(average, 2);
                results[i, 2] = Math.Round(percentage, 2);
            }

            return results;
        }

        // Method to display the scorecard
        public static void DisplayScorecard(int[,] scores, double[,] results) {
            Console.WriteLine("Student\tPhysics\tChemistry\tMath\tTotal\tAverage\tPercentage");

            for (int i = 0; i < scores.GetLength(0); i++) {
                Console.Write(i + 1 + "\t" + scores[i, 0] + "\t" + scores[i, 1] + "\t\t" + scores[i, 2] + "\t"
                              + results[i, 0] + "\t" + results[i, 1] + "\t" + results[i, 2]);
                Console.WriteLine();
            }
        }

        // Main method
        public static void Main() {
            Console.Write("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            // Step 1: Generate random PCM scores
            int[,] scores = GenerateScores(numberOfStudents);

            // Step 2: Calculate total, average, and percentage
            double[,] results = CalculateResults(scores);

            // Step 3: Display the scorecard
            DisplayScorecard(scores, results);
        }
    }
}

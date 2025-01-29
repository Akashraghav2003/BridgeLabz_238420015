// 7.Write a program to take user input for the age of all 10 students in a class and
 // check whether the student can vote depending on his/her age is greater or equal to 18.


using System;

namespace Assignment4 {

    public class StudentVoteChecker {

        // Method to check if the student can vote using if-else
        public static bool CanStudentVote(int age) {
            if (age >= 18) {
                return true; // Age is 18 or above, can vote
            } else {
                return false; // Age is less than 18, cannot vote
            }
        }

        static void Main(string[] args) {
            // Array to hold the ages of 10 students
            int[] studentAges = new int[10];

            // Loop to take input for the age of each student
            for (int i = 0; i < studentAges.Length; i++) {
                Console.Write("Enter the age of student " + (i + 1) + ": ");
                studentAges[i] = Convert.ToInt32(Console.ReadLine());

                // Check if the student can vote
                if (CanStudentVote(studentAges[i])) {
                    Console.WriteLine("Student " + (i + 1) + ": Can vote.");
                } else {
                    Console.WriteLine("Student " + (i + 1) + ": Cannot vote.");
                }
            }
        }
    }
}

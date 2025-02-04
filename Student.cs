using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment
{
    internal class Student
    {
        // Static variable shared by all students
        private static string UniversityName = "Global University";

        // Static variable to track total students
        private static int totalStudents = 0;

        // Readonly variable for unique Roll Number
        private readonly int RollNumber;
        private string Name;
        private string Grade;

        // Constructor to initialize student details
        public Student(string name, string grade)
        {
            this.RollNumber = ++totalStudents; // Assign unique roll number
            this.Name = name;
            this.Grade = grade;
        }

        // Private method to display student details
        private void DisplayStudentDetails()
        {
            if (this is Student) // Using is operator to check instance
            {
                Console.WriteLine($"Roll No: {RollNumber}, Name: {Name}, Grade: {Grade}");
            }
            else
            {
                Console.WriteLine("Invalid student instance.");
            }
        }

        // Private method to update student grade
        private void UpdateGrade(string newGrade)
        {
            if (this is Student)
            {
                this.Grade = newGrade;
                Console.WriteLine($"Grade updated successfully for {Name} (Roll No: {RollNumber})!");
            }
            else
            {
                Console.WriteLine("Invalid student instance. Cannot update grade.");
            }
        }

        // Static method to display total enrolled students
        private static void DisplayTotalStudents()
        {
            Console.WriteLine($"Total Students Enrolled: {totalStudents}");
        }

        // Public method to control private methods
        public void ShowStudentDetails()
        {
            DisplayStudentDetails();
        }

        // Public method to allow grade updates
        public void ChangeGrade(string newGrade)
        {
            UpdateGrade(newGrade);
        }

        // Public static method to access total students count
        public static void ShowTotalStudents()
        {
            DisplayTotalStudents();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // List to store student objects
            List<Student> students = new List<Student>();

            Console.Write("Enter the number of students to enroll: ");
            int numStudents;
            while (!int.TryParse(Console.ReadLine(), out numStudents) || numStudents <= 0)
            {
                Console.Write("Invalid input! Please enter a positive number: ");
            }

            // Loop to create student objects and take input
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"\nEnter details for Student {i + 1}:");

                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Grade: ");
                string grade = Console.ReadLine();

                // Create new Student object and add to list
                Student student = new Student(name, grade);
                students.Add(student);
            }

            // Display all student details
            Console.WriteLine("\nEnrolled Student Details:");
            foreach (var student in students)
            {
                student.ShowStudentDetails();
            }

            // Allow user to update a student's grade
            Console.Write("\nDo you want to update a student's grade? (yes/no): ");
            string updateChoice = Console.ReadLine().ToLower();

            if (updateChoice == "yes")
            {
                Console.Write("Enter Roll Number of the student to update: ");
                int rollNumber;
                while (!int.TryParse(Console.ReadLine(), out rollNumber) || rollNumber <= 0 || rollNumber > students.Count)
                {
                    Console.Write("Invalid roll number! Enter a valid roll number: ");
                }

                Console.Write("Enter the new grade: ");
                string newGrade = Console.ReadLine();

                students[rollNumber - 1].ChangeGrade(newGrade);
            }

            // Display updated student details
            Console.WriteLine("\nUpdated Student Details:");
            foreach (var student in students)
            {
                student.ShowStudentDetails();
            }

            // Show total number of students
            Student.ShowTotalStudents();
        }
    }
}

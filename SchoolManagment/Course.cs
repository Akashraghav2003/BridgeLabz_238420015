using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment
{
    internal class Course
    {
        public string CourseName { get; set; }
        private List<Student> enrolledStudents; // Stores students enrolled in this course

        public Course(string courseName)
        {
            CourseName = courseName;
            enrolledStudents = new List<Student>();
        }

        // Method to enroll a student in this course
        public void EnrollStudent(Student student)
        {
            if (!enrolledStudents.Contains(student))
            {
                enrolledStudents.Add(student);
                student.AddCourse(this); // Also add this course to the student's course list
            }
        }

        // Display students enrolled in this course
        public void ShowEnrolledStudents()
        {
            Console.WriteLine($"\nStudents enrolled in {CourseName}:");
            if (enrolledStudents.Count == 0)
            {
                Console.WriteLine("No students enrolled.");
                return;
            }
            foreach (var student in enrolledStudents)
            {
                Console.WriteLine(student.StudentName);
            }
        }
    }
}

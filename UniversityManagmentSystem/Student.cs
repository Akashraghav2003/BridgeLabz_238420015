using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagmentSystem
{
    internal class Student
    {
        public string StudentName { get; set; }
        public int StudentID { get; set; }
        private List<Course> EnrolledCourses;

        public Student(string name, int id)
        {
            StudentName = name;
            StudentID = id;
            EnrolledCourses = new List<Course>();
        }

        // Enroll in a Course
        public void EnrollCourse(Course course)
        {
            EnrolledCourses.Add(course);
            course.EnrollStudent(this);
        }

        // Display Student Details
        public void ShowStudentDetails()
        {
            Console.WriteLine($"\nStudent ID: {StudentID}, Name: {StudentName}");
            Console.WriteLine("Enrolled Courses:");
            foreach (var course in EnrolledCourses)
            {
                Console.WriteLine($"- {course.CourseName}");
            }
        }
    }
}

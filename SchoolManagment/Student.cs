using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment
{
    internal class Student
    {
        public string StudentName { get; set; }
        private List<Course> enrolledCourses; // Stores courses the student is enrolled in

        public Student(string studentName)
        {
            StudentName = studentName;
            enrolledCourses = new List<Course>();
        }

        // Enroll student in a course
        public void EnrollInCourse(Course course)
        {
            if (!enrolledCourses.Contains(course))
            {
                enrolledCourses.Add(course);
                course.EnrollStudent(this); // Also add this student to the course's student list
            }
        }

        // Add course (used internally when a course enrolls a student)
        public void AddCourse(Course course)
        {
            if (!enrolledCourses.Contains(course))
            {
                enrolledCourses.Add(course);
            }
        }

        // Show courses this student is enrolled in
        public void ShowEnrolledCourses()
        {
            Console.WriteLine($"\n{StudentName} is enrolled in:");
            if (enrolledCourses.Count == 0)
            {
                Console.WriteLine("No courses enrolled.");
                return;
            }
            foreach (var course in enrolledCourses)
            {
                Console.WriteLine(course.CourseName);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagmentSystem
{
    internal class Professor
    {
        public string ProfessorName { get; set; }
        public int ProfessorID { get; set; }
        private List<Course> AssignedCourses;

        public Professor(string name, int id)
        {
            ProfessorName = name;
            ProfessorID = id;
            AssignedCourses = new List<Course>();
        }

        // Assign a Course to Professor
        public void AssignCourse(Course course)
        {
            AssignedCourses.Add(course);
            course.AssignProfessor(this);
        }

        // Display Professor Details
        public void ShowProfessorDetails()
        {
            Console.WriteLine($"\nProfessor ID: {ProfessorID}, Name: {ProfessorName}");
            Console.WriteLine("Assigned Courses:");
            foreach (var course in AssignedCourses)
            {
                Console.WriteLine($"- {course.CourseName}");
            }
        }
    }
}

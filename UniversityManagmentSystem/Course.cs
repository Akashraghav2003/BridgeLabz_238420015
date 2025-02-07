using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagmentSystem
{
    internal class Course
    {
        public string CourseName { get; set; }
        public int CourseID { get; set; }
        private List<Student> EnrolledStudents;
        private List<Professor> AssignedProfessors;

        public Course(string name, int id)
        {
            CourseName = name;
            CourseID = id;
            EnrolledStudents = new List<Student>();
            AssignedProfessors = new List<Professor>();
        }

        // Enroll a student in the course
        public void EnrollStudent(Student student)
        {
            EnrolledStudents.Add(student);
        }

        // Assign a professor to the course
        public void AssignProfessor(Professor professor)
        {
            AssignedProfessors.Add(professor);
        }

        // Show Course Details
        public void ShowCourseDetails()
        {
            Console.WriteLine($"\nCourse ID: {CourseID}, Name: {CourseName}");
            Console.WriteLine("Enrolled Students:");
            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine($"- {student.StudentName} (ID: {student.StudentID})");
            }

            Console.WriteLine("Assigned Professors:");
            foreach (var professor in AssignedProfessors)
            {
                Console.WriteLine($"- {professor.ProfessorName} (ID: {professor.ProfessorID})");
            }
        }
    }
}

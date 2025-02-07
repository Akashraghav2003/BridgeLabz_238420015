using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagmentSystem
{
    internal class UniversitySystemcs
    {
        private List<Student> Students;
        private List<Professor> Professors;
        private List<Course> Courses;

        public UniversitySystemcs()
        {
            Students = new List<Student>();
            Professors = new List<Professor>();
            Courses = new List<Course>();
        }

        // Add Student
        public void AddStudent(string name, int id)
        {
            Students.Add(new Student(name, id));
        }

        // Add Professor
        public void AddProfessor(string name, int id)
        {
            Professors.Add(new Professor(name, id));
        }

        // Add Course
        public void AddCourse(string name, int id)
        {
            Courses.Add(new Course(name, id));
        }

        // Enroll a Student in a Course
        public void EnrollStudentInCourse(int studentId, int courseId)
        {
            Student student = Students.Find(s => s.StudentID == studentId);
            Course course = Courses.Find(c => c.CourseID == courseId);

            if (student != null && course != null)
            {
                student.EnrollCourse(course);
                Console.WriteLine("Student enrolled successfully!");
            }
            else
            {
                Console.WriteLine("Invalid Student or Course ID.");
            }
        }

        // Assign a Professor to a Course
        public void AssignProfessorToCourse(int professorId, int courseId)
        {
            Professor professor = Professors.Find(p => p.ProfessorID == professorId);
            Course course = Courses.Find(c => c.CourseID == courseId);

            if (professor != null && course != null)
            {
                professor.AssignCourse(course);
                Console.WriteLine("Professor assigned successfully!");
            }
            else
            {
                Console.WriteLine("Invalid Professor or Course ID.");
            }
        }

        // Show All Courses
        public void ShowAllCourses()
        {
            Console.WriteLine("\nCourses:");
            foreach (var course in Courses)
            {
                course.ShowCourseDetails();
            }
        }
    }
}

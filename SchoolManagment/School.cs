using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment
{
    internal class School
    {
        public string SchoolName { get; set; }
        private List<Student> students; // Aggregation: School contains students but they can exist independently

        public School(string schoolName)
        {
            SchoolName = schoolName;
            students = new List<Student>();
        }

        // Add a student to the school
        public void AddStudent(Student student)
        {
            if (!students.Contains(student))
            {
                students.Add(student);
            }
        }

        // Show all students in the school
        public void ShowStudents()
        {
            Console.WriteLine($"\nStudents in {SchoolName}:");
            if (students.Count == 0)
            {
                Console.WriteLine("No students enrolled.");
                return;
            }
            foreach (var student in students)
            {
                Console.WriteLine(student.StudentName);
            }
        }
    }
}

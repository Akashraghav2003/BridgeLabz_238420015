using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Student
    {
        public int RollNumber;   // Public member
        protected string Name;    // Protected member
        private double CGPA;      // Private member

        public Student(int rollNumber, string name, double cgpa)
        {
            RollNumber = rollNumber;
            Name = name;
            CGPA = cgpa;
        }

        // Public method to get CGPA
        public double GetCGPA()
        {
            return CGPA;
        }

        // Public method to set CGPA
        public void SetCGPA(double cgpa)
        {
            CGPA = cgpa;
        }
    }
    public class PostgraduateStudent : Student
    {
        public PostgraduateStudent(int rollNumber, string name, double cgpa)
            : base(rollNumber, name, cgpa) { }

        public void DisplayInfo()
        {
            Console.WriteLine("Roll Number: " + RollNumber);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("CGPA: " + GetCGPA());
        }


        public static void Main(string[] args)
        {
            // Creating instance and testing
            PostgraduateStudent student = new PostgraduateStudent(101, "Akash", 8.7);
            student.DisplayInfo();

            student.SetCGPA(9.2);
            Console.WriteLine("Updated CGPA: " + student.GetCGPA());
        }
    }



}

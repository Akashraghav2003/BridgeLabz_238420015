using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagment
{
    internal class Student
    {
        public int RollNumber { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }

        public char Grade { get; set; }

        public Student Next;

        public Student (int rollno , string name, int age, char grade)
        {
            RollNumber = rollno;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }
}

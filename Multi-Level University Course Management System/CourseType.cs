using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_University_Course_Management_System
{
    public abstract class CourseType
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }

        public CourseType(string courseName, string instructor)
        {
            CourseName = courseName;
            Instructor = instructor;
        }

        // Abstract method (each course type implements it differently)
        public abstract void DisplayEvaluationMethod();
    }
}

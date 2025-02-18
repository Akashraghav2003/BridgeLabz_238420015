using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_University_Course_Management_System
{
    public class ExamCourse : CourseType
    {
        public int ExamDuration { get; set; } // In minutes

        public ExamCourse(string courseName, string instructor, int examDuration)
            : base(courseName, instructor)
        {
            ExamDuration = examDuration;
        }

        public override void DisplayEvaluationMethod()
        {
            Console.WriteLine($"{CourseName} \n (Instructor: {Instructor}) \n Evaluation: Exam ({ExamDuration} mins)");
        }
    }
}

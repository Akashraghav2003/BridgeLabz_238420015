using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_University_Course_Management_System
{
    public class AssignmentCourse : CourseType
    {
        public int TotalAssignments { get; set; }

        public AssignmentCourse(string courseName, string instructor, int totalAssignments)
            : base(courseName, instructor)
        {
            TotalAssignments = totalAssignments;
        }

        public override void DisplayEvaluationMethod()
        {
            Console.WriteLine($"{CourseName} \n(Instructor: {Instructor}) \nEvaluation: {TotalAssignments} Assignments");
        }
    }
}

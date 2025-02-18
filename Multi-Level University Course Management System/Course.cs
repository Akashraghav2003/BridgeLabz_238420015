using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_University_Course_Management_System
{
    public class Course<T> where T : CourseType
    {
        private List<T> courses = new List<T>();

        // Add Course
        public void AddCourse(T course)
        {
            courses.Add(course);
        }

        // Display All Courses
        public void DisplayAllCourses()
        {
            Console.WriteLine("\n--- Course List ---");
            foreach (var course in courses)
            {
                course.DisplayEvaluationMethod();
            }
        }
    }
}

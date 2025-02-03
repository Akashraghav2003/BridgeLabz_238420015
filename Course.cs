using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Course
    {
        public string courseName { get; set; }
        public int duration { get; set; }
        public int fee { get; set; }

        public static string instituteName = "Gla University.";

        public Course(string courseName, int duration, int fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }
        public void DisplayCourseDetails()
        {
            Console.WriteLine($"Course Name: {courseName}, Duration: {duration}, fee: {fee}, institute: {instituteName}");
        }

        public void UpdateInstituteName(string newInstituteName)
        {
            instituteName = newInstituteName;
        }

        public static void Main(string[] args)
        {

            Console.Write("Enter course name: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter course duration in year: ");
            int duration = int.Parse(Console.ReadLine());

            Console.Write("Enter course fee: ");
            int fee = int.Parse(Console.ReadLine());

            // Creating course object with user input
            Course course = new Course(courseName, duration, fee);

            // Displaying course details
            course.DisplayCourseDetails();

            Course course1 = new Course(courseName, duration, fee);
            Console.Write("Enter institute name: ");
            string newInstituteName = Console.ReadLine();
            course1.UpdateInstituteName(newInstituteName);
            course1.DisplayCourseDetails();
        }

    }
}

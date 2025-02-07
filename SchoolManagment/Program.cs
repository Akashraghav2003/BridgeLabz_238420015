using SchoolManagment;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter school name: ");
        string schoolName = Console.ReadLine();
        School school = new School(schoolName);

        List<Course> courses = new List<Course>
            {
                new Course("Math"),
                new Course("Science"),
                new Course("History")
            };

        Console.Write("Enter number of students: ");
        int studentCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < studentCount; i++)
        {
            Console.Write($"Enter Student {i + 1} Name: ");
            string studentName = Console.ReadLine();
            Student student = new Student(studentName);
            school.AddStudent(student);

            Console.WriteLine("Available Courses:");
            for (int j = 0; j < courses.Count; j++)
            {
                Console.WriteLine($"{j + 1}. {courses[j].CourseName}");
            }

            Console.Write("Enter the number of courses to enroll in: ");
            int courseCount = int.Parse(Console.ReadLine());

            for (int j = 0; j < courseCount; j++)
            {
                Console.Write($"Select Course {j + 1} (Enter Course Number): ");
                int courseChoice = int.Parse(Console.ReadLine());

                if (courseChoice >= 1 && courseChoice <= courses.Count)
                {
                    student.EnrollInCourse(courses[courseChoice - 1]);
                }
                else
                {
                    Console.WriteLine("Invalid course selection.");
                }
            }
        }

        // Display results
        school.ShowStudents();

        foreach (var student in school.GetType().GetField("students", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(school) as List<Student>)
        {
            student.ShowEnrolledCourses();
        }

        foreach (var course in courses)
        {
            course.ShowEnrolledStudents();
        }
    }
}
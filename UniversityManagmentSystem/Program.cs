using UniversityManagmentSystem;

class Program
{
    static void Main(string[] args)
    {
        UniversitySystemcs university = new UniversitySystemcs();

        Console.Write("\nEnter number of Students: ");
        int studentCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < studentCount; i++)
        {
            Console.Write($"Enter Student {i + 1} Name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter Student {i + 1} ID: ");
            int id = int.Parse(Console.ReadLine());
            university.AddStudent(name, id);
        }

        Console.Write("\nEnter number of Professors: ");
        int professorCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < professorCount; i++)
        {
            Console.Write($"Enter Professor {i + 1} Name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter Professor {i + 1} ID: ");
            int id = int.Parse(Console.ReadLine());
            university.AddProfessor(name, id);
        }

        Console.Write("\nEnter number of Courses: ");
        int courseCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < courseCount; i++)
        {
            Console.Write($"Enter Course {i + 1} Name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter Course {i + 1} ID: ");
            int id = int.Parse(Console.ReadLine());
            university.AddCourse(name, id);
        }

        Console.Write("\nDo you want to enroll students in courses? (yes/no): ");
        while (Console.ReadLine().ToLower() == "yes")
        {
            Console.Write("Enter Student ID: ");
            int studentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Course ID: ");
            int courseId = int.Parse(Console.ReadLine());

            university.EnrollStudentInCourse(studentId, courseId);
            Console.Write("\nDo you want to enroll another student? (yes/no): ");
        }

        Console.Write("\nDo you want to assign professors to courses? (yes/no): ");
        while (Console.ReadLine().ToLower() == "yes")
        {
            Console.Write("Enter Professor ID: ");
            int professorId = int.Parse(Console.ReadLine());
            Console.Write("Enter Course ID: ");
            int courseId = int.Parse(Console.ReadLine());

            university.AssignProfessorToCourse(professorId, courseId);
            Console.Write("\nDo you want to assign another professor? (yes/no): ");
        }

        university.ShowAllCourses();
    }
}
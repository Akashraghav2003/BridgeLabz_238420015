using UniversityMAnagment;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter University Name: ");
        string uniName = Console.ReadLine();
        University university = new University(uniName);

        Console.Write("\nEnter number of Faculty Members: ");
        int facultyCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < facultyCount; i++)
        {
            Console.Write($"Enter Faculty {i + 1} Name: ");
            string facultyName = Console.ReadLine();
            university.AddFaculty(new Faculty(facultyName));  // Aggregation
        }

        Console.Write("\nEnter number of Departments: ");
        int departmentCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < departmentCount; i++)
        {
            Console.Write($"Enter Department {i + 1} Name: ");
            string deptName = Console.ReadLine();
            university.AddDepartment(deptName);  // Composition
        }

        // Display University, Departments, and Faculties
        university.ShowDetails();

        // Demonstrate Deletion of University (Composition)
        Console.Write("\nDo you want to delete the university? (yes/no): ");
        string deleteChoice = Console.ReadLine().ToLower();

        if (deleteChoice == "yes")
        {
            university.DeleteUniversity();
        }

        Console.WriteLine("\nFaculty members still exist (Aggregation Demonstration):");
        foreach (var faculty in university.GetType().GetField("faculties", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(university) as List<Faculty>)
        {
            faculty.ShowDetails();
        }
    }
}
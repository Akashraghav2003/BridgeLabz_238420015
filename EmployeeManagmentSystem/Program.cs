namespace EmployeeManagmentSystem;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Enter the name of Employee:");
        string name = Console.ReadLine ();

        Console.WriteLine ("Enter the Employee ID");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the salary");
        double salary  = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the team size");
        int teamSize = Convert.ToInt32(Console.ReadLine());

        Manager manager = new Manager(name, id, salary, teamSize);
        manager.DisplayDetails();

        Console.WriteLine("Enter the Programming language");
        string programmingLanguage = Console.ReadLine ();

        Developer developer = new Developer(name, id, salary, programmingLanguage);
        developer.DisplayDetails();

        Console.WriteLine("Enter the Intenship Duration ");
        string intenshipDuration = Console.ReadLine ();

        Intern intern = new Intern(name, id, salary, intenshipDuration);
        intern.DisplayDetails();
    }
}
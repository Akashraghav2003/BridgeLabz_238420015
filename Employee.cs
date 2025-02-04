using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_second
{
    internal class Employee
    {
        // Static variable shared by all employees
        private static string CompanyName = "Tech Solutions";

        // Static variable to keep track of total employees
        private static int totalEmployees = 0;

        // Readonly variable for employee ID
        private readonly int Id;
        private string Name;
        private string Designation;

        // Constructor to initialize employee details
        public Employee()
        {
            this.Id = ++totalEmployees; // Assigning unique ID
        }

        // Private method to take user input
        private void GetDetails()
        {
            Console.Write("Enter Employee Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Employee Designation: ");
            Designation = Console.ReadLine();
        }

        // Private method to display employee details
        private void DisplayEmployeeDetails()
        {
            if (this is Employee) // Using is operator to check instance
            {
                Console.WriteLine($"Employee ID: {Id}, Name: {Name}, Designation: {Designation}");
            }
            else
            {
                Console.WriteLine("Invalid employee instance.");
            }
        }

        // Private static method to display total employees
        private static void DisplayTotalEmployees()
        {
            Console.WriteLine($"Total Employees: {totalEmployees}");
        }

        // Private static method to display company name
        private static void DisplayCompanyName()
        {
            Console.WriteLine($"Company Name: {CompanyName}");
        }

        // Public method to call private methods inside the Employee class
        public void StartEmployeeProcess()
        {
            GetDetails();
            DisplayEmployeeDetails();
        }

        // Public static method to call private static methods
        public static void ShowCompanyDetails()
        {
            DisplayTotalEmployees();
            DisplayCompanyName();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Creating first employee and processing details
            Employee emp1 = new Employee();
            emp1.StartEmployeeProcess();

            // Creating second employee and processing details
            Employee emp2 = new Employee();
            emp2.StartEmployeeProcess();

            // Displaying company and total employee details
            Employee.ShowCompanyDetails();
        }
    }


}

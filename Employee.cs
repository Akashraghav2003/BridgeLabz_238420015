using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Employee
    {
        public int EmployeeID;
        protected string Department;
        private double Salary;

        public Employee(int employeeID, string department, double salary)
        {
            EmployeeID = employeeID;
            Department = department;
            Salary = salary;
        }

        // Method to get the salary
        public double GetSalary()
        {
           return Salary;
        }

        // Method to set the salary
        public void SetSalary(double salary)
        {
            Salary = salary;
        }
    }

    public class Manager : Employee
    {
        public Manager(int employeeID, string department, double salary)
            : base(employeeID, department, salary) { }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee ID: " + EmployeeID);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Salary: " + GetSalary());
        }
        static void Main(string[] args)
        {
            Manager manager = new Manager(101, "Sales", 60000);
            manager.DisplayEmployeeInfo();

            // Modifying salary using setter
            manager.SetSalary(65000);
            Console.WriteLine("Updated Salary: " + manager.GetSalary());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem
{
    public abstract class Employee
    {
        private int employeeId;
        private string name;
        private double baseSalary;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public Employee(int id, string name, double baseSalary)
        {
            this.employeeId = id;
            this.name = name;
            this.baseSalary = baseSalary;
        }

        public abstract double CalculateSalary();

        public void DisplayDetails()
        {
            Console.WriteLine($"ID : {employeeId}, Name : {name}, Salary :{CalculateSalary():c}");
        }

    }
}

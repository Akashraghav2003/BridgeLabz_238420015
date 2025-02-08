using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary  { get; set; }

        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {Name}, Employee ID : {Id}, Employee Salary {Salary}");
        }
    }
}

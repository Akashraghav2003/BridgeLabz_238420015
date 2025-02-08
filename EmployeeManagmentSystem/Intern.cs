using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem
{
    internal class Intern : Employee
    {
        public string IntenshipDuration { get; set; }
        
        public Intern ( string name, int id, double salary, string intenshipDuration ) : base (name, id, salary)
        {
            IntenshipDuration = intenshipDuration;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {Name}, Employee ID : {Id}, Employee Salary {Salary}, Intenship Duration: {IntenshipDuration}");
        }
    }
}

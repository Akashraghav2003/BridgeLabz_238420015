using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem
{
    internal class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer( string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {Name}, Employee ID : {Id}, Employee Salary {Salary}, Programming Lannguage {ProgrammingLanguage}");
        }
    }
}

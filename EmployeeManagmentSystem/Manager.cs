using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem
{
    internal class Manager :Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
        {
            TeamSize = teamSize;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {Name}, Employee ID : {Id}, Employee Salary {Salary}, Team Size {TeamSize}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem
{
    internal class FullTimeEmployee : Employee, IDepartment
    {
        private string department;

        public FullTimeEmployee(int id, string name, double salary) : base(id, name, salary) { }


        public void AssignDepartment(string department)
        {
            this.department = department;
        }

        public override double CalculateSalary()
        {
            return BaseSalary;
        }

        public string GetDepartmentDetails()
        {
            return $"Department: {department}";
        }
    }
}

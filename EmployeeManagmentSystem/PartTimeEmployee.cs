using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem
{
    internal class PartTimeEmployee : Employee, IDepartment
    {
        private int hoursWorked;
        private double hourlyRate;
        private string department;
        public void AssignDepartment(string department)
        {
            this.department = department;
        }

        public PartTimeEmployee(int id, string name, double hourlyRate, int hoursWorked)
        : base(id, name, hourlyRate * hoursWorked)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }


        public override double CalculateSalary()
        {
            return hourlyRate * hoursWorked;
        }

        public string GetDepartmentDetails()
        {
            return $"Department :{department}";
        }
    }
}

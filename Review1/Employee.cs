using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    internal class Employee
    {
        private string employeeName;
        private int employeeId;
        private int employeeAge;
        private string department;

        public Employee(String employeeName, int employeeId, int employeeAge, string department)
        {
            this.employeeName = employeeName;
            this.employeeId = employeeId;
            this.employeeAge = employeeAge;
            this.department = department;

        }
        public Employee()
        {

        }

        public void ShowDetails()
        {
            Console.WriteLine($"Employee Name: {employeeName}, EmpoyeeId: {employeeId}, Employee Age: {employeeAge}, Department {department}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CompneyAndDepartment
{
    internal class Department
    {
        private string departmentName;
        private Employee employee;
        private static int totalEmployee;
        private List<Employee> employees;


        public Department(string departmentName)
        {
            this.departmentName = departmentName;
            employee = new Employee();

        }

        public void AddEmployee()
        {
            Console.WriteLine("Enter the Employee Id: ");
            int employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter the Employee Age:");
            int employeeAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Department Name");
            string departmentName = Console.ReadLine();

            employee = new Employee(employeeId, employeeName, employeeAge);
            employees.Add(employee);

            totalEmployee++;
            

        }

        public void RemoveEmployee()
        {
            Console.WriteLine("Enter the employee ID that you want to remove ");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            Employee selectEmployee = employees.FirstOrDefault(e => e.Equals(employeeId);

            if (selectEmployee != null)
            {
                employees.Remove(selectEmployee);
                Console.WriteLine("Given Employee is Removed");
            }
            else
            {
                Console.WriteLine("Given correct employee ID");
            }


        }
        
    }
}

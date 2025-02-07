using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    internal class Department
    {
        private String departmentName;
        private Employee employee;
        private List<Employee> employees = new List<Employee>();
        public int totalEmployee;

        public Department(String departmentName)
        {
            this.departmentName = departmentName;
            //Employee employee = new Employee();
        }
        public Department()
        {

        }

        public void AddEmployee()
        {
            Console.WriteLine("Enter the Employee Id: ");
            int employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Enter the Employee Age:");
            int employeeAge = Convert.ToInt32(Console.ReadLine());


            Employee employee = new Employee(employeeName,employeeId, employeeAge,this.departmentName);
            employees.Add(employee);

            totalEmployee++;


        }

        public void RemoveEmployee()
        {
            Console.WriteLine("Enter the employee ID that you want to remove ");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            Employee selectEmployee = employees.FirstOrDefault(e => e.Equals(employeeId));

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

        public void SwitchCase()
        {
            while (true)
            {
                Console.WriteLine("Choose the operation: ");
                Console.WriteLine("1.Add Employee \n2.Total Employee \n3.view the details of employee \n4.exits\n5.remove Employee");
                int opeartion = Convert.ToInt32(Console.ReadLine());

                switch(opeartion)
                {
                    case 1:
                        AddEmployee(); 
                        break;
                    case 2:
                        Console.WriteLine($"Total Employee {totalEmployee}");
                        break;
                        
                    case 3:
                        employee.ShowDetails();
                        break;
                    case 4:
                        return;
                        
                    case 5:
                        RemoveEmployee();
                        break;

                    default:
                        Console.WriteLine("Enter the Write operation");
                        break;
                }
            }
        }
    }
}


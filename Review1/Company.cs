using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    public class Company
    {
        private static string compamyName = "Capgemini";
 
        private List<Department> departments;

        public Company()
        {
            departments = new List<Department>();
            
        }

        public void GetDepartment()
        {
            //Console.WriteLine(Department.ToString());
            Console.WriteLine("Enter the Department of employee");
            string departmentName = Console.ReadLine();

            Department department = new Department(departmentName);
            departments.Add(department);

            department.SwitchCase();

        }

        public void SwitchCase()
        {
            

            while (true)
            {
                Console.WriteLine("Choose the operations");

                Console.WriteLine("1.give the details of department \n2.exits");
                int operation = Convert.ToInt32(Console.ReadLine());

                switch(operation)
                {
                    case 1:
                        GetDepartment(); 
                        break;
                    case 2:
                        return;

                    default:
                        Console.WriteLine("Enter the valid operation");
                        break;
                }
            }
        }
    }
}

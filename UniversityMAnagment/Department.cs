using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityMAnagment
{
    internal class Department
    {
        public string DepartmentName { get; set; }

        public Department(string name)
        {
            DepartmentName = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Department: {DepartmentName}");
        }
    }
}

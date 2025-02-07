using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityMAnagment
{
    internal class Faculty
    {
        public string FacultyName { get; set; }

        public Faculty(string name)
        {
            FacultyName = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Faculty Name: {FacultyName}");
        }
    }
}

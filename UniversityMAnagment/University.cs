using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityMAnagment
{
    internal class University
    {
            public string UniversityName { get; set; }
            private List<Department> departments;  // Composition: University owns Departments
            private List<Faculty> faculties;       // Aggregation: Faculty exists independently

            public University(string name)
            {
                UniversityName = name;
                departments = new List<Department>();
                faculties = new List<Faculty>();
            }

            // Add a Department (Composition)
            public void AddDepartment(string deptName)
            {
                departments.Add(new Department(deptName));
            }

            // Add a Faculty Member (Aggregation)
            public void AddFaculty(Faculty faculty)
            {
                faculties.Add(faculty);
            }

            // Display University Details
            public void ShowDetails()
            {
                Console.WriteLine($"\nUniversity: {UniversityName}");

                Console.WriteLine("\nDepartments:");
                if (departments.Count == 0) Console.WriteLine("No Departments Available.");
                foreach (var dept in departments)
                    dept.ShowDetails();

                Console.WriteLine("\nFaculty Members:");
                if (faculties.Count == 0) Console.WriteLine("No Faculty Members Available.");
                foreach (var faculty in faculties)
                    faculty.ShowDetails();
            }

            // Deleting University Deletes all Departments (Composition)
            public void DeleteUniversity()
            {
                Console.WriteLine($"\nDeleting University: {UniversityName}");
                departments.Clear(); // Composition - Departments are deleted with University
                Console.WriteLine("All Departments Deleted.");
            }
        }
    }

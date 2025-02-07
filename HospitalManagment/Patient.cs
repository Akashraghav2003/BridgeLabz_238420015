using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagment
{
    internal class Patient
    {
        public string PatientName { get; set; }
        public int PatientID { get; set; }

        public Patient(string name, int id)
        {
            PatientName = name;
            PatientID = id;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Patient ID: {PatientID}, Name: {PatientName}");
        }
    }
}

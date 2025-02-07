using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagment
{
    internal class Doctor
    {
        public string DoctorName { get; set; }
        public int DoctorID { get; set; }
        private List<Patient> patients;  // List of patients associated with the doctor

        public Doctor(string name, int id)
        {
            DoctorName = name;
            DoctorID = id;
            patients = new List<Patient>();
        }

        // Consult method to show doctor-patient interaction
        public void Consult(Patient patient)
        {
            patients.Add(patient);
            Console.WriteLine($"Doctor {DoctorName} is consulting Patient {patient.PatientName}.");
        }

        // Display assigned patients
        public void ShowPatients()
        {
            Console.WriteLine($"\nDoctor: {DoctorName}, ID: {DoctorID} is consulting the following patients:");
            if (patients.Count == 0)
            {
                Console.WriteLine("No Patients Assigned.");
                return;
            }
            foreach (var patient in patients)
            {
                Console.WriteLine($"- {patient.PatientName} (ID: {patient.PatientID})");
            }
        }
    }
}

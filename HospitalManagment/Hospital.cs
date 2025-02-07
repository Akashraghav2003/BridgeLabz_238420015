using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagment
{
    internal class Hospital
    {
        public string HospitalName { get; set; }
        private List<Doctor> doctors;
        private List<Patient> patients;

        public Hospital(string name)
        {
            HospitalName = name;
            doctors = new List<Doctor>();
            patients = new List<Patient>();
        }

        // Add Doctor
        public void AddDoctor(string name, int id)
        {
            doctors.Add(new Doctor(name, id));
        }

        // Add Patient
        public void AddPatient(string name, int id)
        {
            patients.Add(new Patient(name, id));
        }

        // Perform Consultation
        public void ConsultDoctor(int doctorId, int patientId)
        {
            Doctor doctor = doctors.Find(d => d.DoctorID == doctorId);
            Patient patient = patients.Find(p => p.PatientID == patientId);

            if (doctor == null || patient == null)
            {
                Console.WriteLine("Invalid Doctor or Patient ID.");
                return;
            }

            doctor.Consult(patient);
        }

        // Display all Doctors
        public void ShowDoctors()
        {
            Console.WriteLine("\nDoctors in Hospital:");
            foreach (var doctor in doctors)
                Console.WriteLine($"Doctor ID: {doctor.DoctorID}, Name: {doctor.DoctorName}");
        }

        // Display all Patients
        public void ShowPatients()
        {
            Console.WriteLine("\nPatients in Hospital:");
            foreach (var patient in patients)
                Console.WriteLine($"Patient ID: {patient.PatientID}, Name: {patient.PatientName}");
        }

        // Show all Doctor-Patient Consultations
        public void ShowConsultations()
        {
            foreach (var doctor in doctors)
            {
                doctor.ShowPatients();
            }
        }
    }
}

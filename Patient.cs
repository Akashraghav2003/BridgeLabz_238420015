using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalManagementSystem
{
    internal class Patient
    {
        // Static variable shared among all patients
        private static string HospitalName = "City Central Hospital Mathura";

        // Static variable to count total patients
        private static int totalPatients = 0;

        // Readonly variable for unique Patient ID
        private readonly int PatientID;
        private string Name;
        private int Age;
        private string Ailment;

        // Constructor to initialize patient details
        public Patient(string name, int age, string ailment)
        {
            this.PatientID = ++totalPatients; // Assign unique Patient ID
            this.Name = name;
            this.Age = age;
            this.Ailment = ailment;
        }

        // Private method to display patient details
        private void DisplayPatientDetails()
        {
            if (this is Patient) // Using is operator to check instance
            {
                Console.WriteLine($"Patient ID: {PatientID}, Name: {Name}, Age: {Age}, Ailment: {Ailment}");
                Console.WriteLine($"Hospital: {HospitalName}");
            }
            else
            {
                Console.WriteLine("Invalid patient instance.");
            }
        }

        // Static method to get total patients
        private static void GetTotalPatients()
        {
            Console.WriteLine($"Total Patients Admitted: {totalPatients}");
        }

        // Public method to control private methods
        public void ShowPatientDetails()
        {
            DisplayPatientDetails();
        }

        // Public static method to allow access to total patients count
        public static void ShowTotalPatients()
        {
            GetTotalPatients();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // List to store patient records
            List<Patient> patients = new List<Patient>();

            Console.Write("Enter the number of patients to admit: ");
            int numPatients;
            while (!int.TryParse(Console.ReadLine(), out numPatients) || numPatients <= 0)
            {
                Console.Write("Invalid input! Please enter a positive number: ");
            }

            // Loop to create patient records
            for (int i = 0; i < numPatients; i++)
            {
                Console.WriteLine($"\nEnter details for Patient {i + 1}:");

                Console.Write("Enter Patient Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
                {
                    Console.Write("Invalid input! Enter a valid positive age: ");
                }

                Console.Write("Enter Ailment: ");
                string ailment = Console.ReadLine();

                // Create new Patient object and add to list
                Patient patient = new Patient(name, age, ailment);
                patients.Add(patient);
            }

            // Display all admitted patients
            Console.WriteLine("\nAdmitted Patients Details:");
            foreach (var patient in patients)
            {
                patient.ShowPatientDetails();
            }

            // Display total number of admitted patients
            Patient.ShowTotalPatients();
        }
    }
}


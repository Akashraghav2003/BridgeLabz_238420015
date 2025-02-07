using HospitalManagment;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Hospital Name: ");
        string hospitalName = Console.ReadLine();
        Hospital hospital = new Hospital(hospitalName);

        Console.Write("\nEnter number of Doctors: ");
        int doctorCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < doctorCount; i++)
        {
            Console.Write($"Enter Doctor {i + 1} Name: ");
            string docName = Console.ReadLine();
            Console.Write($"Enter Doctor {i + 1} ID: ");
            int docId = int.Parse(Console.ReadLine());
            hospital.AddDoctor(docName, docId);
        }

        Console.Write("\nEnter number of Patients: ");
        int patientCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < patientCount; i++)
        {
            Console.Write($"Enter Patient {i + 1} Name: ");
            string patName = Console.ReadLine();
            Console.Write($"Enter Patient {i + 1} ID: ");
            int patId = int.Parse(Console.ReadLine());
            hospital.AddPatient(patName, patId);
        }

        // Show initial details
        hospital.ShowDoctors();
        hospital.ShowPatients();

        // Performing Consultations
        while (true)
        {
            Console.Write("\nDo you want to assign a patient to a doctor? (yes/no): ");
            string choice = Console.ReadLine().ToLower();
            if (choice != "yes") break;

            Console.Write("Enter Doctor ID: ");
            int docId = int.Parse(Console.ReadLine());
            Console.Write("Enter Patient ID: ");
            int patId = int.Parse(Console.ReadLine());

            hospital.ConsultDoctor(docId, patId);
        }

        // Show final consultation details
        hospital.ShowConsultations();
    }
}
namespace HospitalTriageSystem
{
	class Program
	{
        static void Main()
        {
            HospitalTriage hospital = new HospitalTriage();

            hospital.AddPatient("John", 3);
            hospital.AddPatient("Alice", 5);
            hospital.AddPatient("Bob", 2);

            hospital.ProcessPatients();
        }
    }
}
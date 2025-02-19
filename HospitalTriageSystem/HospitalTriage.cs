using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTriageSystem
{
    internal class HospitalTriage
    {
        private SortedSet<(int, string)> queue = new SortedSet<(int, string)>(Comparer<(int, string)>.Create(
        (a, b) => b.Item1 == a.Item1 ? a.Item2.CompareTo(b.Item2) : b.Item1.CompareTo(a.Item1)));

        public void AddPatient(string name, int severity)
        {
            queue.Add((severity, name));
        }

        public void ProcessPatients()
        {
            Console.WriteLine("Patients will be treated in this order:");
            foreach (var patient in queue)
            {
                Console.WriteLine(patient.Item2);
            }
        }
    }
}

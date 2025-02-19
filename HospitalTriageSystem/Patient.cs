using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalTriageSystem
{
    internal class Patient
    {
        public string Name { get; set; }
        public int Severity { get; set; }

        public Patient(string name, int severity)
        {
            Name = name;
            Severity = severity;
        }
    }
}

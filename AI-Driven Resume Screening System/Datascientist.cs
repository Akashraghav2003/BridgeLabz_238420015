using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Driven_Resume_Screening_System
{
    internal class Datascientist
    {
        public class DataScientist : JobRole
        {
            public string Specialization { get; set; }

            public DataScientist(string candidateName, int experience, string specialization)
                : base(candidateName, experience)
            {
                Specialization = specialization;
            }

            public override void DisplayDetails()
            {
                Console.WriteLine($"Data Scientist - {CandidateName} \n Experience: {Experience} years \n Specialization: {Specialization}");
            }
        }
    }
}

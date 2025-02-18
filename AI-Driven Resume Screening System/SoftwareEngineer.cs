using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Driven_Resume_Screening_System
{
    public class SoftwareEngineer : JobRole
    {
        public string ProgrammingLanguage { get; set; }

        public SoftwareEngineer(string candidateName, int experience, string programmingLanguage)
            : base(candidateName, experience)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Software Engineer - {CandidateName} \n Experience: {Experience} years \n Primary Language: {ProgrammingLanguage}");
        }
    }

}

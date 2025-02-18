using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Driven_Resume_Screening_System
{
    public abstract class JobRole
    {
        public string CandidateName { get; set; }
        public int Experience { get; set; }

        public JobRole(string candidateName, int experience)
        {
            CandidateName = candidateName;
            Experience = experience;
        }

        public abstract void DisplayDetails();
    }

}

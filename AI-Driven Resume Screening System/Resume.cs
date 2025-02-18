using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Driven_Resume_Screening_System
{
    public class Resume<T> where T : JobRole
    {
        private List<T> applicants = new List<T>();

        public void AddApplicant(T applicant)
        {
            applicants.Add(applicant);
        }

        public void ProcessApplications()
        {
            Console.WriteLine("\nProcessing Applications...");
            foreach (var applicant in applicants)
            {
                applicant.DisplayDetails();
            }
        }
    }

}







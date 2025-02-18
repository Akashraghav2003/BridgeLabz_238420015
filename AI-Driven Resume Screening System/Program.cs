using AI_Driven_Resume_Screening_System;
using static AI_Driven_Resume_Screening_System.Datascientist;

class Program
{
    static void Main()
    {
        // Resume collection for Software Engineers
        Resume<SoftwareEngineer> softwareEngineerResumes = new Resume<SoftwareEngineer>();
        softwareEngineerResumes.AddApplicant(new SoftwareEngineer("Ishwar Singh", 5, "C#"));
        softwareEngineerResumes.AddApplicant(new SoftwareEngineer("Akash", 3, "Java"));

        // Resume collection for Data Scientists
        Resume<DataScientist> dataScientistResumes = new Resume<DataScientist>();
        dataScientistResumes.AddApplicant(new DataScientist("Anil", 4, "Machine Learning"));
        dataScientistResumes.AddApplicant(new DataScientist("Vansh", 6, "Deep Learning"));

        // Process all resumes
        softwareEngineerResumes.ProcessApplications();
        dataScientistResumes.ProcessApplications();
    }
}
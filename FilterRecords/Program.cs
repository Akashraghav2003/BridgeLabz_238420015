using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

namespace FilterRecords
{
	class Program
	{
        static void Main(string[] args)
        {
            try 
            {
                string path = "student_marks1.csv";

                if (!File.Exists(path))
                {
                    throw (new FileNotFoundException());
                }

                using(var reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.Read();
                    csv.ReadHeader();

                    while (csv.Read())
                    {
                        double marks = csv.GetField<double>("Average Marks");
                        if (marks >= 80)
                        {
                            string name = csv.GetField("Name");
                            string gender = csv.GetField("Gender");

                            Console.WriteLine($"Name: {name}, Gender: {gender}, Marks: {marks}");
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
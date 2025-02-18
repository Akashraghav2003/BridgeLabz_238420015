using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuliderQuestions
{

    internal class StreamReaderFile
    {
        static void Main(string[] args)
        {
            string file = "D:\\akash gla university\\capgemini problem\\feature15-02-2025\\sample.txt";
            //string file = "C:\\Users\\frinds system\\Desktop\\New Text Document.txt";



            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)//Read Line By Line
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }


}
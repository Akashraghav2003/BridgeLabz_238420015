using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingFileNotFoundException
{
    internal class FileHandling
    {
        public void ReadFile(string path)
        {
            try
            {
                if(File.Exists(path))
                {
                    string Content = File.ReadAllText(path);
                    Console.WriteLine(Content);
                }
                else
                {
                    throw new IOException("File not found");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

using System;
using System.IO;
using System.Text;

namespace ReadAndWriteTextFile
{
	class Program
	{
        static void Main(string[] args)
        {
            string path = @"D:\akash gla university\capgemini problem\feature20-02-2025\ReadAndWrite.txt";
            string path2 = @"D:\akash gla university\capgemini problem\feature20-02-2025\ReadWrite.txt";

            using (FileStream fr = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fw = new FileStream(path2, FileMode.Create, FileAccess.ReadWrite))
                {

                    int i;
                    while ((i = fr.ReadByte()) != -1)
                    {
                        fw.WriteByte((Byte)i);
                    }
                    Console.WriteLine("File is copied");

                    //Again reset to -1;
                    fw.Seek(0, SeekOrigin.Begin);
                    int j;
                    while ((j = fw.ReadByte()) != -1)
                    {
                        Console.Write((char)j);
                    }
                }
            }

        }
    }
}
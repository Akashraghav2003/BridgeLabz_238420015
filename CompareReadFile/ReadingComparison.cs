using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareReadFile
{
    internal class ReadingComparison
    {
        public static long ReadUsingStreamReader(string filePath)
        {
            long start = DateTime.Now.Ticks;
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.Read() != -1) { } // Read character by character
            }
            long end = DateTime.Now.Ticks;
            return (end - start) / 10000; // Convert ticks to milliseconds
        }

        // Read file using FileStream (Byte-based reading)
        public static long ReadUsingFileStream(string filePath)
        {
            long start = DateTime.Now.Ticks;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[4096]; // 4KB buffer for efficient reading
                while (fs.Read(buffer, 0, buffer.Length) > 0) { }
            }
            long end = DateTime.Now.Ticks;
            return (end - start) / 10000; // Convert ticks to milliseconds
        }

    }
}

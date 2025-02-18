using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparesionOfStringConcatenation
{
    internal class StringConcatenation
    {
        static long ConcatenateWithString(int count)
        {
            string str = "";
            long startTime = DateTime.Now.Ticks;

            for (int i = 0; i < count; i++)
            {
                str += "test"; // Creates a new object each time (O(N²))
            }

            long endTime = DateTime.Now.Ticks;
            return (endTime - startTime) / 10000; // Convert ticks to milliseconds
        }

        // Method to measure time taken for StringBuilder concatenation
        static long ConcatenateWithStringBuilder(int count)
        {
            StringBuilder sb = new StringBuilder();
            long startTime = DateTime.Now.Ticks;

            for (int i = 0; i < count; i++)
            {
                sb.Append("test"); // Uses internal buffer, avoids creating new objects (O(N))
            }

            long endTime = DateTime.Now.Ticks;
            return (endTime - startTime) / 10000; // Convert ticks to milliseconds
        }

    }
}

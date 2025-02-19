using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateBinaryNumbersUsingQueue
{
    internal class BinaryNumberGenerator
    {
        public static List<string> GenerateBinaryNumbers(int N)
        {
            List<string> result = new List<string>();
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("1"); // Start with "1"

            for (int i = 0; i < N; i++)
            {
                string binary = queue.Dequeue();
                result.Add(binary);

                // Generate next two binary numbers
                queue.Enqueue(binary + "0");
                queue.Enqueue(binary + "1");
            }

            return result;
        }
    }
}

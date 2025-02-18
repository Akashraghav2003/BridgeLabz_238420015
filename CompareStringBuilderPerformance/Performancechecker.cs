using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareStringBuilderPerformance
{
    internal class Performancechecker
    {
        public long PerformanceCheckStringBulider(long iterations, string str)
        {
            StringBuilder sb = new StringBuilder();
            long start, end;
            start = DateTime.Now.Ticks;
            for (int i = 0; i < iterations; i++)
            {
                sb.Append(str);
            }
            end = DateTime.Now.Ticks;
            return end - start;
        }

        public long PerformanceCheckString(long iterations, string str)
        {
            string newStr = "";
            long start, end;
            start = DateTime.Now.Ticks;
            for (int i = 0; i < iterations; i++)
            {
                newStr += str;
            }
            end = DateTime.Now.Ticks;
            return end - start;
        }

    }
}

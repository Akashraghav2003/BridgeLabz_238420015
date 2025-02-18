using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringUsingStringBuilder
{
    internal class ReverseString
    {
        
        public StringBuilder Reverse(StringBuilder sb)
        {
            int i = 0, j = sb.Length - 1;
            while (i < j)
            {
                char temp = sb[i];
                sb[i++] = sb[j];
                sb[j--] = temp;
                
            }
            return sb;

        }
    }
}

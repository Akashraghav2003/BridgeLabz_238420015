using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FristNegativeNumber
{
    internal class FristNegative
    {
        public int Negative(int[] arr)
        {
            int length = arr.Length;
            int result = 0;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] < 0)
                {
                    result = arr[i];
                    break;
                }
            }

            return result;
        }
    }
}

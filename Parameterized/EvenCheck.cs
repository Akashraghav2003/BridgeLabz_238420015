using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterized
{
    public class EvenCheck
    {
        public bool IsEven(int num)
        {
            bool flag = false;

            if (num % 2 == 0)
            {
                flag = true;
            }
            return flag;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class DivideException
    {
        public static double Divide(double divisor, double divident)
        {
            if (divident == 0)
            {
                throw new DivideByZeroException();
            }

            double result = divisor / divident;

            return result;
        }
    }
}

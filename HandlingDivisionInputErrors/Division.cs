using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingDivisionInputErrors
{
    internal class Division
    {
        public double divide(double a, double b)
        {
            if(b == 0) { throw new DivideByZeroException(); }
           double c;
            c = a / b; 
            return c;  

        }
    }
}

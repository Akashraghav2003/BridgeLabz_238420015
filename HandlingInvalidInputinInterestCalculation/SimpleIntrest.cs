using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingInvalidInputinInterestCalculation
{
    internal class SimpleIntrest : Exception
    {
        public  SimpleIntrest(string msg) : base(msg) { }
        public static  double Intrest(double amount, double rate, int year)
        {
            if (amount < 0 || rate < 0)
            {
                throw new SimpleIntrest(" amount and rate is negative");
            }
            double si = (amount * rate * year) / 100.0;
            return si;  
        }
    }

}

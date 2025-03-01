using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateaTheAge
{
    internal class AgeCheck: Exception
    {
        public AgeCheck(string msg): base(msg){ }
        public static void CheckError(int age)
        {
            if (age < 18) { throw new AgeCheck("Invalid age exception: age sholud be greater then 18"); }
        }
    }
}

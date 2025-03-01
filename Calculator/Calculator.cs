using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class Calculator
    {
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double result { get; set; }

        public Calculator(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }


        public double Add()
        {
            result = num1 + num2;
            return result;
        }

        public double Substract()
        {
            result = num1 - num2;
            return result;
        }

        public double Multiply()
        {
            result = num1 * num2;
            return result;
        }

        public double Divide()
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            result = num1 / num2;
            return result;
        }



    }
}

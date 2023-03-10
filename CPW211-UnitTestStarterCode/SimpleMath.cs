using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode
{
    /*****************************************************************************
    * 
    * YOU MAY REFACTOR THE PARAMETER NAMES BUT DO NOT CHANGE THE METHOD SIGNATURES
    * 
    * ***************************************************************************/
    public static class SimpleMath
    {
        public static double Add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        public static double Subtract(double a, double b)
        {
            double difference = a - b;
            return difference;
        }

        public static double Multiply(double a, double b)
        {
            double product = a * b;
            return product;
        }

        public static double Divide(double a, double b)
        {
            if (b <= 0)
            {
                throw new ArgumentException($"The {nameof(b)} must be something other than 0 to divide");
            }

            double dividend = a / b;
            return dividend;
        }
    }
}

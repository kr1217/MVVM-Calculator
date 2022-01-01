using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Calculator
{
    public class Calculator
    {
        private double value1 = 0.0;
        private double value2 = 0;

        public Calculator(double val1, double val2)
        {
            value1 = val1;
            value2 = val2;
        }

        public double Add()
        {
            return value1 + value2;
        }

        public double Subtract()
        {
            return value1 - value2;
        }

        public double Multiply()
        {
            return value1 * value2;
        }

        public double Divide()
        {

            return value1 / value2;
        }
    }
}

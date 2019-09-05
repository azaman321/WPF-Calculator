using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculte
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public class Calculate
        {
            public double Add(double num1, double num2)
            {
                return num1 + num2;
            }

            public double Sub(double num1, double num2)
            {
                return num1 - num2;
            }

            public double Div(double num1, double num2)
            {
                return num1 / num2;
            }

            public double Mult(double num1, double num2)
            {
                return num1 * num2;
            }
        }
    }
}

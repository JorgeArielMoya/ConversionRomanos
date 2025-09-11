using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionRomanos
{
    internal class OperacionesHelper
    {
        public static int CalcularFactorial (int num)
        {
            for (int i = num; i > 0; i++)
            {
                num *= i;
            }

            return num;
        }
    }
}

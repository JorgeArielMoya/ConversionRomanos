using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionRomanos
{
    internal class ConversionesHelper
    {
        public static int ConvertirRomanoDecimal(string numRomano) 
        { 
            int total = 0, preValor = 0;

            for (int i = numRomano.Length - 1; i >= 0; i--)
            {
                char caracter = numRomano[i];

                int valor = ConvertirCaracterRomano(caracter);

                if (valor == -1)
                {
                    return -1;
                }

                if (valor < preValor)
                {
                    total -= valor;
                }

                else
                {
                    total += valor;
                }

                preValor = valor;
            }

            return total;
        }

        private static int ConvertirCaracterRomano(char caracter)
        {
            switch(caracter)
            {
                case 'I':
                    return 1;

                case 'V':
                    return 5;

                case 'X':
                    return 10;

                case 'L':
                    return 50;

                case 'C':
                    return 100;

                case 'D':
                    return 500;

                case 'M':
                    return 1000;

                default:
                    return -1;
            }
        }
    }
}

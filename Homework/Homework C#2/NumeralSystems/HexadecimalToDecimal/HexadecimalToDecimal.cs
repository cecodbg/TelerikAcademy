// Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Enter number to convert 0x... : ");
            string[] str = Console.ReadLine()
                                  .Select(x => x.ToString())
                                  .Reverse()
                                  .ToArray();

            int number = 0;
            for (int i = 0; i < str.Length - 2; i++)
            {
                int a = 0;
                bool isCorect = int.TryParse(str[i], out a);
                if (isCorect)
                {
                    number += (a * Pow(16, i));
                }
                else
                {
                    char ch = Convert.ToChar(str[i]);
                    if (ch - 'A' < 6)
                    {
                        number += (ch - 'A' + 10) * Pow(16, i);
                    }
                    else
                    {
                        number += (ch - 'a' + 10) * Pow(16, i);
                    }
                }
            }

            Console.WriteLine("Number after convert is: {0}", number);
        }

        static int Pow(int baseNumber, int pow)
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= baseNumber;
            }
            return result;
        }

    }
}

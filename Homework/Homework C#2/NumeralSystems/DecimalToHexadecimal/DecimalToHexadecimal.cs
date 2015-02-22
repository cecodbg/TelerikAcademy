// Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter number to convert: ");
            int number = int.Parse(Console.ReadLine());

            List<char> convert = new List<char>();
            while (number % 16 > 0)
            {
                while (number % 16 <= 9 && number % 16 > 0)
                {
                    convert.Add(Convert.ToChar((number % 16) + 48));
                    number /= 16;
                }
                while (number % 16 > 9)
                {
                    convert.Add(Convert.ToChar((number % 16) + 55));
                    number /= 16;
                }
            }
            convert.Reverse();
            Console.WriteLine("Number after convert is: 0x{0}", string.Join("", convert));
        }
    }
}

// Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Enter number to convert: ");
            int number = int.Parse(Console.ReadLine());
            List<int> binary = new List<int>();

            while (number > 0)
            {
                binary.Add(number % 2);
                number /= 2;
            }

            binary.Reverse();
            Console.WriteLine("After convert to binary: {0}", string.Join("", binary));
        }
    }
}
 
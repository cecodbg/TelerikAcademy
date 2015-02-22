// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryShort
{
    class BinaryShort
    {
        static void Main()
        {
            Console.Write("Enter number to convert: ");
            short number = short.Parse(Console.ReadLine());
            List<short> result = new List<short>();
            bool isNegative = number < 0;

            if (isNegative)
            {
                short mask = 32767;
                number = (short)(number & mask);
            }

            while (number > 0)
            {
                short divider = 2;
                result.Add((short)(number % divider));
                number /= 2;
            }

            if (isNegative)
            {
                result.Add(1);
            }

            result.Reverse();
            Console.WriteLine("After convert number is: {0}", string.Join("", result).PadLeft(16, '0'));
        }
    }
}

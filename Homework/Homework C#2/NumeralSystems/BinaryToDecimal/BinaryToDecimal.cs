// Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Enter number to convert: ");
            int[] numbers = Console.ReadLine()
                                   .Select(x => x - '0')
                                   .Reverse()
                                   .ToArray();
            //Console.WriteLine(string.Join("", numbers));
            int number = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                number += numbers[i] * (1 << i);
            }
            Console.WriteLine("After convert number is: {0}", number);
        }
    }
}

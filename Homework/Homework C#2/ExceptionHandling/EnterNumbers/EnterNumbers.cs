// Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
// If an invalid number or non-number text is entered, the method should throw an exception.
// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1 < a1 < a2 < a3 < a4 < a5 < a6 < a7 < a8 < a9 < a10 < 100
namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            int start = 1;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Enter number in range from {0} to {1}", start + 1, 91 + i);
                int number = ReadNumber(start, i + 91);
                start = number;
            }
        }

        static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());

            if (number <= start || number >= end)
            {
                throw new ArgumentOutOfRangeException(string.Format("Invalid number. the number must be between {0} and {1}", start + 1, end - 1));
            }

            return number;
        }
    }
}

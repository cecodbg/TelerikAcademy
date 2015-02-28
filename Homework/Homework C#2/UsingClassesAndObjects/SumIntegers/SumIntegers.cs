// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntegers
{
    class SumIntegers
    {
        static void Main()
        {
            Console.WriteLine("Eneter numbers, separated by spase: ");
            int[] numbers = Console.ReadLine()
                                   .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(x => int.Parse(x))
                                   .ToArray();
            
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}

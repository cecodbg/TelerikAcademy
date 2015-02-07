// Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class ProgramCompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] arr1 = new char[5];
            char[] arr2 = new char[5];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("{0, 2}", arr1[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("{0, 2}", arr2[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine("Char from arr1 of position {0} is equally to char from arr2 of position {1} ", i, j);
                    }
                }
            }
        }
    }
}

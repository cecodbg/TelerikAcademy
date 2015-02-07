//Write a program that reads two integer arrays from the console and compares them element by element

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("{0, 3}", arr1[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("{0, 3}", arr2[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine("Element from arr1 of position {0} is equal to element from arr2 of position {1} ", i, j);
                    }
                }
            }
        }
    }
}

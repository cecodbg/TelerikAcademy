// Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int[] arr= new int[10];
            int currentCount = 1;
            int maxCount = 0;
            int num = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount >= maxCount)
                {
                    maxCount = currentCount;
                    num = arr[i];
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write("{0, 2}", num);
            }
            Console.WriteLine();
        }
    }
}

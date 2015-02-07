// Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers for the array: ");
            string[] stringNumbersArray = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[10];
            for (int i = 0; i < stringNumbersArray.Length; i++)
            {
                array[i] = (int.Parse(stringNumbersArray[i]));
            }

            int currentCount = 1;
            int maxCount = 0;
            int num = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] - array[i] == 1)
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
                    num = array[i + 2 - (maxCount)];
                }
            }

            for (int i = 0; i < maxCount; i++)
            {
                Console.Write("{0, 2}", num + i);
            }
            Console.WriteLine();
        }
    }
}

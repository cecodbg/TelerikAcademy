// Write a program that finds the sequence of maximal sum in given array.
// Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array: ");
            string[] numbersArray = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[numbersArray.Length];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                array[i] = (int.Parse(numbersArray[i]));
            }

            int startIndex = 0;
            int currentSum = 0;
            int maxSum = int.MinValue;
            int start = 0;
            int end = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (currentSum <= 0)
                {
                    startIndex = i;
                    currentSum = 0;
                }

                currentSum += array[i];

                if(currentSum > maxSum)
                {
                    maxSum = currentSum;
                    start = startIndex;
                    end = i;
                }
            }

            for (int i = start; i <= end; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

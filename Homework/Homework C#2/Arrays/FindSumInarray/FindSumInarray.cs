// Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumInarray
{
    class FindSumInarray
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
            Console.WriteLine("Enter sum: ");
            int sum = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int startIndex = 0;
            int start = 0;
            int end = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (currentSum < sum && count == 0)
                {
                    startIndex = i;
                    count++;
                }

                currentSum += array[i];

                if(currentSum == sum)
                {
                    start = startIndex;
                    end = i;
                    break;
                }
                else if (currentSum > sum)
                {
                    currentSum = array[i];
                    startIndex = i;
                }
            }

            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}

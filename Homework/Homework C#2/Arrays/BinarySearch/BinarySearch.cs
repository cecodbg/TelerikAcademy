// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
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
            Console.WriteLine("Enter searches number : ");
            int searchesNumber = int.Parse(Console.ReadLine());

            Array.Sort(array);
            int minIndex = 0;
            int maxIndex = array.Length - 1;
            int middleIndex = 0;

            while (minIndex <= maxIndex)
            {
                middleIndex = (minIndex + (maxIndex)) / 2;
                if (array[middleIndex] == searchesNumber)
                {
                    Console.WriteLine(array[middleIndex - 1]);
                    break;
                }
                else if (array[middleIndex] > searchesNumber)
                {
                    maxIndex = middleIndex - 1;
                }
                else
                {
                    minIndex = middleIndex + 1;
                }
            } 

            if (minIndex > maxIndex)
            {
                Console.WriteLine("The searched number is not  in this array");
            }
        }
    }
}

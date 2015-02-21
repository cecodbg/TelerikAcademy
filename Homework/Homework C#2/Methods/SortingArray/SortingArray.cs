// Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class SortingArray
    {
        static void Main()
        {
            int[] numbers = { 1, 5, 6, 4, 7, 9, 2, 6, 47, 22, 14, 3, 20, 50 };
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine("Enter 1 for return the maximal element \nEnter 2 for sorts an array in ascending order \nEnter 3 for sortes an array in descending order ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.Write("Enter starting at given index: ");
                    int startindex = int.Parse(Console.ReadLine());
                    Console.WriteLine(MaximalElement(numbers, startindex));
                    break;
                case 2:Console.WriteLine(string.Join(", ", SortArray(numbers)));
                    break;
                case 3: Console.WriteLine(string.Join(", ", DescendingSortArray(numbers)));
                    break;
                default:
                    break;
            }
        }

        static int MaximalElement(int[] numbers, int startindex)
        {
            int result = int.MinValue;
            int index = 0;
            for (int i = startindex; i < numbers.Length; i++)
            {
                if (numbers[i] > result)
                {
                    result = numbers[i];
                    index = i;
                }
            }
            numbers[index] = 0;
            return result;
        }

        static int[] DescendingSortArray(int[] numbers)
        {
            int[] sortArray = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                sortArray[i] = MaximalElement(numbers, 0);
            }
            return sortArray;
        }

        static int[] SortArray(int[] numbers)
        {
            int[] descendingSortArray = new int[numbers.Length];
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                descendingSortArray[i] = MaximalElement(numbers, 0);
            }
            return descendingSortArray;
        }

    }
}

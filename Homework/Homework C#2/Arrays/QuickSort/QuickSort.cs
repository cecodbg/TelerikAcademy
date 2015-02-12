// Write a program that sorts an array of integers using the Quick sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter numbers, separated by a comma: ");
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            SortArray(numbers, 0, numbers.Length - 1);

            Console.WriteLine(String.Join(", ", numbers));
        }

        private static void SortArray(int[] numbers, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(numbers, left, right);

                if (pivot > 1)
                {
                    SortArray(numbers, left, pivot - 1);
                }

                if (pivot + 1 < right)
                {
                    SortArray(numbers, pivot + 1, right);
                }
            }
        }

        private static int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];

            while (true)
            {
                while (numbers[left] < pivot)
                {
                    left++;
                }

                while (numbers[right] > pivot)
                {
                    right--;
                }

                if (numbers[right] == numbers[left] && numbers[left] == pivot)
                    ++left;

                if (left < right)
                {
                    numbers[left] ^= numbers[right];
                    numbers[right] ^= numbers[left];
                    numbers[left] ^= numbers[right];
                }
                else
                {
                    return right;
                }
            }
        }
    }
}

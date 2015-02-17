// Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

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
            Console.WriteLine("Eneter numbers, separated by a comma: ");
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            Console.Write("Enter integer k: ");
            int integer = int.Parse(Console.ReadLine());

            Array.Sort(numbers);
            Console.WriteLine("The sorted array is:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            int result = Array.BinarySearch(numbers, integer);

            if (result == -1)
            {
                Console.WriteLine("The number {} is less than the smallest number in the array", integer);
            }
            else if (result < -1)
            {
                int realResult = ~result - 1;
                Console.WriteLine("The largest number in the array which is < {0} is {1} is located pozicion {2} in sorted array", integer, numbers[realResult], realResult);
            }
            else if (result > 0)
            {
                Console.WriteLine("There Number {0} in the array and an index of {1}", integer, result);
            }
        }
    }
}

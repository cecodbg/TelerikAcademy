// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
// Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
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

            for (int i = 0; i < array.Length; i++)
            {
                int minValue = int.MaxValue;
                int minValueIndex = 0;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < minValue)
                    {
                        minValue = array[j];
                        minValueIndex = j;
                    }
                }
                array[minValueIndex] = array[i];
                array[i] = minValue;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0, 2}", array[i]);
            }
            Console.WriteLine();
        }
    }
}

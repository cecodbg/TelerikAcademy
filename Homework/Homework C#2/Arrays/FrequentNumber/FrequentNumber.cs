// Write a program that finds the most frequent number in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class FrequentNumber
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

            int times = 0;
            int counter = 0;
            int maxCounter = int.MinValue;
            int mostFrequentNumber = 0;
            List<int> usedNumber = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (usedNumber.Contains(array[i]))
                {
                    continue;
                }
                counter = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }

                if (maxCounter < counter)
                {
                    mostFrequentNumber = array[i];
                    times = counter;
                    maxCounter = counter;
                }
                usedNumber.Add(array[i]);
            }
            Console.WriteLine("{0} ({1} times)", mostFrequentNumber, times);
        }
    }
}

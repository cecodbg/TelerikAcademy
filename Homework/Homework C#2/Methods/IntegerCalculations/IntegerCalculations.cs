// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
// Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main()
        {
            Console.WriteLine("Minimal value the given set of integers is: {0}", MinValue(1,2,3,4,5,6));
            Console.WriteLine("Maximal value the given set of integers is: {0}", MaxValue(1,2,3,4,5,6));
            Console.WriteLine("The sum of given set of integers is: {0}", Sum(1,2,3,4,5,6));
            Console.WriteLine("The product of given set of integers is: {0}", Product(1,2,3,4,5,6));
            Console.WriteLine("The average value of given set of integers is: {0}", Average(1,2,3,4,5,6));
        }

        static int MinValue(params int[] elements)
        {
            int minValue = int.MaxValue;
            foreach (int number in elements)
            {
                minValue = Math.Min(minValue, number);
            }
            return minValue;
        }

        static int MaxValue(params int[] elements)
        {
            int maxValue = int.MinValue;
            foreach (int number in elements)
            {
                maxValue = Math.Max(maxValue, number);
            }
            return maxValue;
        }

        static long Sum(params long[] elements)
        {
            long sum = 0;
            foreach (int number in elements)
            {
                sum += number;
            }
            return sum;
        }

        static long Product(params long[] elements)
        {
            long product = 1;
            foreach (long number in elements)
            {
                product *= number;
            }
            return product;
        }

        static double Average(params int[] elements)
        {
            double average = elements.Average();
            return average;
        }
    }
}

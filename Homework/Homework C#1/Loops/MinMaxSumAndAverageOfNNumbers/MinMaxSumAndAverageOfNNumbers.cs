// Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
// The output is like in the examples below.

using System;
using System.Globalization;
using System.Threading;

namespace MinMaxSumAndAverageOfNNumbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            int counter = 0;
            double[] integer = new double[number]; 

            while (counter < number)
            {
                integer[counter] = double.Parse(Console.ReadLine());
                counter++;
            }

            double min = integer[0];
            for (int i = 0; i < integer.Length; i++)
            {
                min = Math.Min(min, integer[i]);
            }

            double max = integer[0];
            for (int i = 0; i < integer.Length; i++)
            {
                max = Math.Max(max, integer[i]);
            }

            double sum = 0;
            for (int i = 0; i < integer.Length; i++)
            {
                sum += integer[i]; 
            }

            double avg = sum / number;

            Console.WriteLine("Min value is: {0}", min);
            Console.WriteLine("Max value is: {0}", max);
            Console.WriteLine("Sum value is: {0}", sum);
            Console.WriteLine("Avg value is: {0:0.00}", avg);         
        }
    }
}

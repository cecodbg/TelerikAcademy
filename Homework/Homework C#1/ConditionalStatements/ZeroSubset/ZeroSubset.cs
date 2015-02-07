// We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
// Assume that repeating the same subset several times is not a problem.

using System;
using System.Text;

namespace ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            Console.WriteLine("Enter five number:");
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            int fourthInt = int.Parse(Console.ReadLine());
            int fifthInt = int.Parse(Console.ReadLine());

            StringBuilder current = new StringBuilder();
            StringBuilder totalString = new StringBuilder();
            int subsetInt = 0;
            int sum;

            for (int i = 1; i <= 30; i++)
            {
                current.Clear();
                sum = 0;
                if ((i & 1) == 1)
                {
                    sum = sum + firstInt;
                    current.AppendFormat("{0} ", firstInt);
                }
                if (((i >> 1) & 1) == 1)
                {
                    sum = sum + secondInt;
                    current.AppendFormat("{0} ", secondInt);
                }
                if (((i >> 2) & 1) == 1)
                {
                    sum = sum + thirdInt;
                    current.AppendFormat("{0} ", thirdInt);
                }
                if (((i >> 3) & 1) == 1)
                {
                    sum = sum + fourthInt;
                    current.AppendFormat("{0} ", fourthInt);
                }
                if (((i >> 4) & 1) == 1)
                {
                    sum = sum + fifthInt;
                    current.AppendFormat("{0} ", fifthInt);
                }
                if (sum == 0)
                {
                    subsetInt++;
                    current.Append("= 0");
                    totalString.AppendLine(current.ToString());
                }
            }
            if (subsetInt == 0)
            {
                Console.WriteLine("no zero subset");
            }

            Console.WriteLine(totalString);
        }
    }
}

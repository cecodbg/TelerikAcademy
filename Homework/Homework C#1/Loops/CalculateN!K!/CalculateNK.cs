// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
// Use only one loop.

using System;
using System.Numerics;

namespace CalculateNK
{
    class CalculateNK
    {
        static void Main()
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter nymber k: ");
            int k = int.Parse(Console.ReadLine());

            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
                if (i <= k)
                {
                    kFactorial *= i;
                }
            }
            BigInteger result = nFactorial / kFactorial;
            Console.WriteLine(result);
        }
    }
}

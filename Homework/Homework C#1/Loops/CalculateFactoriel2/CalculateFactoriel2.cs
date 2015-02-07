// In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

namespace CalculateFactoriel2
{
    class CalculateFactoriel2
    {
        static void Main()
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter nymber k: ");
            int k = int.Parse(Console.ReadLine());

            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger nKFactoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
                if (i <= k)
                {
                    kFactorial *= i;
                } 
                if (i <= n - k)
                {
                    nKFactoriel *= i;
                }
            }

            BigInteger result = nFactorial / (kFactorial * nKFactoriel);
            Console.WriteLine(result);
        }
    }
}

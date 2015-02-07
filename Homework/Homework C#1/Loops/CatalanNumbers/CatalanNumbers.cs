// In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
// Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());

            BigInteger nFactorial = 1;
            BigInteger twoNFactorial = 1;
            BigInteger n1Factoriel = 1;
            for (int i = 1; i <= 2 * n; i++)
            {
                twoNFactorial *= i;

                if (i <= n + 1)
                {
                    n1Factoriel *= i;
                }

                if (i <= n)
                {
                    nFactorial *= i;
                }
            }

            BigInteger result = twoNFactorial / (n1Factoriel * nFactorial);
            Console.WriteLine(result);
        }
    }
}

// Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 120;
            bool[] primeNumbers = new bool[n];

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (primeNumbers[i] == false)
                {
                    for (int j = i * i; j < primeNumbers.Length; j += i)
                    {
                        primeNumbers[j] = true;
                    }
                }
            }

            for (int i = 2; i < primeNumbers.Length; i++)
            {
                if (!primeNumbers[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

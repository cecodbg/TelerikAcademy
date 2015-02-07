// Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
// Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Numerics;

namespace TrailingZerosInNFactorial
{
    class TrailingZerosInNFactorial
    {
        static void Main()
        {
            BigInteger number;
            Console.Write("Entnr number N: ");
            bool isCorrectInput = BigInteger.TryParse(Console.ReadLine(), out number);

            while (isCorrectInput == false || number <= 0)
            {
                Console.Write("In correct input! Try again: ");
                isCorrectInput = BigInteger.TryParse(Console.ReadLine(), out number);
            }

            BigInteger del = 5;
            BigInteger sum = 0;
            BigInteger result = 1;
            for (int i = 1; number >= del; i++)
            {
                result = number / del;
                del *= 5;
                sum += result;
            }
            Console.WriteLine("Zeros in N! are {0}", sum);
        }
    }
}


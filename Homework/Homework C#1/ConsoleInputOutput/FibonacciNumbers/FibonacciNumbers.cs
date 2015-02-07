// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;
using System.Numerics;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            BigInteger a = 0;
            BigInteger b = 1;
            Console.Write("{0}, {1}, ", a ,b);
            BigInteger sum = 0;

            for (int i = 0; i < n - 2; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
                Console.Write("{0}, ", sum);
            }
        }
    }
}

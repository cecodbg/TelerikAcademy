// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Collections.Generic;

namespace RandomizeTheNumbers1_N
{
    class RandomizeTheNumbers1_N
    {
        static void Main()
        {
            Console.Write("Enter number n: ");
            int number = int.Parse(Console.ReadLine());

            List<int> integer = new List<int>();
            Random gen = new Random();

            for (int i = 1; i <= number; i++)
            {
                integer.Add(i);
            }

            //if (integer.Count > 0)
            //{
            //    int ranInteger = gen.Next(0, integer.Count);
            //}

            for (int i = 0; i < integer.Count; i++)
            {
                int ranInteger = gen.Next(1, integer.Count + 1);
                Console.Write(ranInteger + " ");
            }
            Console.WriteLine();
        }
    }
}

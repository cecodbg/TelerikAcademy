// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

using System;

namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());

            int counter = 1;
            for (int i = 0; i < n; i++)
            {
                counter = i + 1;
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 3}", counter);
                    counter++;
                }

                Console.WriteLine();
            }
        }
    }
}

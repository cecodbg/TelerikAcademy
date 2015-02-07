// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

namespace RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.Write("Enter number n: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter min value: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter max value: ");
            int max = int.Parse(Console.ReadLine());

            Random gen = new Random();
            int digits = 0;

            for (int i = 0; i < number; i++)
            {
                digits = gen.Next(min, max + 1);
                Console.Write(digits + " ");
            }
                Console.WriteLine();
        }
    }
}

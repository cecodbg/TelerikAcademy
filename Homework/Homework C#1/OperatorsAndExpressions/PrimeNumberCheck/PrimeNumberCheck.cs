// Write an expression that checks if given positive integer number n (n <= 100) is prime
// (i.e. it is divisible without remainder only to itself and 1).

using System;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0 || number == 0 || number == 1)
            {
                Console.WriteLine("False");
            }
            else
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("Folse");
                }

            }
        }
    }
}

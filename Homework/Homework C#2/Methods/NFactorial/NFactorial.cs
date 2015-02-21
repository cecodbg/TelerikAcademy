// Write a program to calculate n! for each n in the range [1..100]. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            Console.Write("Enter number for calculate n!(1....100): ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of number {0} is: \n{1}", number, CalculateFactorial(number));
        }

        static BigInteger CalculateFactorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}

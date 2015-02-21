// Write a method GetMax() with two parameters that returns the larger of two integers.
// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int max = GetMax(firstNumber, secondNumber);
            Console.Write("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            GetMax(thirdNumber, max);
            Console.WriteLine("Largest number is {0}",GetMax(thirdNumber, max));
        }

        static int GetMax(int a, int b)
        {
            int maxValue = Math.Max(a, b);
            return maxValue;
        }

    }
}

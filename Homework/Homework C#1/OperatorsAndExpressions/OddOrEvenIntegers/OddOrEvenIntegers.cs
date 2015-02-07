// Write an expression that checks if given integer is odd or even.

using System;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.WriteLine("Enter number for check: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Odd? " + "false");
            }
            else
            {
                Console.WriteLine("Odd? " + "true");
            }
        }
    }
}

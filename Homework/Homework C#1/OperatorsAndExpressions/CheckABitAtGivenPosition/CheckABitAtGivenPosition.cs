// Write a Boolean expression that returns if the bit at position p
// (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

namespace CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter integer n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit p:");
            int p = int.Parse(Console.ReadLine());

            int mask = 1 << p;
            int nAndMask = n & mask;
            int result = nAndMask >> p;

            if (result == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

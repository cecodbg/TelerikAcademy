// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0

using System;

namespace ExtractBitThree
{
    class ExtractBitThree
    {
        static void Main()
        {
            Console.WriteLine("Enter unsigned integer:");
            int number = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            int numberaAndMask = number & mask;
            int newNumber = numberaAndMask >> 3;

            Console.WriteLine(newNumber);

        }
    }
}

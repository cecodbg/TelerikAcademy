// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary
// representation of n while preserving all other bits in n.

using System;

namespace ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter integer nuber n:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position p");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit value v:");
            int bitValue = int.Parse(Console.ReadLine());
            
            int result = 0;

            if (bitValue == 1)
            {
                int mask = bitValue << position;
                result = number | mask;
            }
            else
            {
                int mask = ~(1 << position);
                result = number & mask;
            }

            Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine(result);
            
        }

    }
}

// Write an expression that extracts from given integer n the value of given bit at index p.
using System;

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
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

            Console.WriteLine(result);
        }
    }
}

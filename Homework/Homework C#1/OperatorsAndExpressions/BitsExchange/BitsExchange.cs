// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            Console.WriteLine("Enter unsidned integer:");
            uint integer = uint.Parse(Console.ReadLine());
            Console.WriteLine("Before exchange {0}, {1}", integer, Convert.ToString(integer, 2).PadLeft(32, '0'));
            uint afterExchange = integer;

            for (int i = 3; i <= 5; i++)
            {
                int mask = (1 << i);
                int mask2 = 1 << (i + 21);
                uint bit1AndMask = integer & (uint)mask;
                uint bit1 = bit1AndMask >> i;
                uint bit24AndMask = integer & (uint)mask2;
                uint bit24 = bit24AndMask >> (i + 21);

                if (bit1 != bit24)
                {
                    int newMask = (int)bit1 << (i + 21);
                    afterExchange = afterExchange | (uint)newMask;
                    int newMask2 = (int)bit24 << i;
                    afterExchange = afterExchange | (uint)newMask2;
                    if (bit1 == 0)
                    {
                        int newMask3 = ~(1 << (i + 21));
                        afterExchange = afterExchange & (uint)newMask3;
                    }
                    if (bit24 == 0)
                    {
                        int newMask4 = ~(1 << i);
                        afterExchange = afterExchange & (uint)newMask4;
                    }
                }
            }
            Console.WriteLine("After  exchange {0}, {1}", afterExchange, Convert.ToString(afterExchange, 2).PadLeft(32, '0'));
        }
    }
}

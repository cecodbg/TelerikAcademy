// Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
// The first and the second sequence of bits may not overlap.

using System;

namespace BitExchangeAdvanced
{
    class BitExchangeAdvanced
    {
        static void Main()
        {
            Console.WriteLine("Enter unsidned integer:");
            uint integer = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter position P:");
            int positionP = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position Q:");
            int positionQ = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Before  exchange {0}, {1}", integer, Convert.ToString(integer, 2).PadLeft(32, '0'));

            if (positionP < 0 || positionP > 32 || positionQ < 0 || positionQ > 32 || (positionP + k) > 32 || (positionQ + k) > 32)
            {
                Console.WriteLine("out of range");
            }
            else if (positionP > positionQ && (positionQ + k) >= positionP)
            {
                Console.WriteLine("overlapping");
            }
            else if (positionQ > positionP && (positionP + k) >= positionQ)
            {
                Console.WriteLine("overlapping");
            }
            else if (positionP == positionQ)
            {
                Console.WriteLine("overlapping");
            }
            else
            {
                uint afterExchange = integer;

                for (int i = 0, p = positionP, q = positionQ; i < k; i++, p++, q++)
                {
                    int mask = 1 << p;
                    int mask2 = 1 << q;
                    uint bitpAndMask = integer & (uint)mask;
                    uint bitp = bitpAndMask >> p;
                    uint bitqAndMask = integer & (uint)mask2;
                    uint bitq = bitqAndMask >> q;

                    if (bitp != bitq)
                    {
                        int newMask = (int)bitp << q;
                        afterExchange = afterExchange | (uint)newMask;
                        int newMask2 = (int)bitq << p;
                        afterExchange = afterExchange | (uint)newMask2;

                        if (bitp == 0)
                        {
                            int newMask3 = ~(1 << q);
                            afterExchange = afterExchange & (uint)newMask3;
                        }
                        if (bitq == 0)
                        {
                            int newMask4 = ~(1 << p);
                            afterExchange = afterExchange & (uint)newMask4;
                        }
                    }
                }
                Console.WriteLine("After  exchange {0}, {1}", afterExchange, Convert.ToString(afterExchange, 2).PadLeft(32, '0'));
            }
        }
    }
}

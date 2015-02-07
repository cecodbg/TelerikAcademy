// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint,
// long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
// Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
// Submit the source code of your Visual Studio project as part of your homework submission.

using System;

namespace DeclareVariables
{
    class DeclareVariables
    {
        static void Main()
        {
            byte tito = 97;
            sbyte pipy = -115;
            short mimy = -10000;
            ushort kiky = 52130;
            uint tuty = 4825932;

            Console.WriteLine("I am type byte {0}.", tito);
            Console.WriteLine("I am type sbyte {0}.", pipy);
            Console.WriteLine("I am type short {0}.", mimy);
            Console.WriteLine("I am type ushort {0}.", kiky);
            Console.WriteLine("I can be from type int and uint {0}.", tuty);
        }
    }
}

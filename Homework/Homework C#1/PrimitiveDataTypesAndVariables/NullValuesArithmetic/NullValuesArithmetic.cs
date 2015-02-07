// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.

using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? number = null;
            double? num = null;

            Console.WriteLine("!{0}!, !{1}!", number, num);
            Console.WriteLine("Number" + number + "2");
            Console.WriteLine("Double" + num + "2");
        }
    }
}

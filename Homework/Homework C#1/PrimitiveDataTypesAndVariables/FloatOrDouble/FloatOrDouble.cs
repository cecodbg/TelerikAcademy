// Which of the following values can be assigned to a variable of type float and which to a variable of type double:
// 34.567839023, 12.345, 8923.1234857, 3456.091?
// Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

namespace FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main()
        {
            float koko = 12.345F;
            float bobo = 3456.091F;
            double pepy = 34.567839023;
            double tito = 8923.1234857;

            Console.WriteLine("I am type float {0}, {1}.", koko, bobo);
            Console.WriteLine("I am type double {0}, {1}.", pepy, tito);
        }
    }
}

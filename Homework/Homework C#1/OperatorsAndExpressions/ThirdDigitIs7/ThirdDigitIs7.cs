//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

namespace ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            number /= 100;
            if (number % 10 == 7)
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

// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("False");
            }

            if ((number % 7 == 0) && (number % 5 == 0))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

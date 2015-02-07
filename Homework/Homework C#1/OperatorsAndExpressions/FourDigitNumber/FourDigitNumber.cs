// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
// Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
// Prints on the console the number in reversed order: dcba (in our example 1102).
// Puts the last digit in the first position: dabc (in our example 1201).
// Exchanges the second and the third digits: acbd (in our example 2101).

using System;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter four-digit number: ");
            int number = int.Parse(Console.ReadLine());
            int firstDigit = 0;
            int secondDigit = 0;
            int thirdDigits = 0;
            int fourthDigits = 0;
            
            for (int i = 0; i <= 9; i++)
            {
                if (number % 10 == i)
                {
                    fourthDigits = i;
                }
            }

            number /= 10;
            for (int i = 0; i <= 9; i++)
            {           
                if (number % 10 == i)
                {
                    thirdDigits = i;
                }
            }

            number /= 10;
            for (int i = 0; i <= 9; i++)
            {
                if (number % 10 == i)
                {
                    secondDigit = i;
                }
            }

            number /= 10;
            for (int i = 0; i <= 9; i++)
            {
                if (number % 10 == i)
                {
                    firstDigit = i;
                }
            }

            int sum = 0;
            sum = firstDigit + secondDigit + thirdDigits + fourthDigits;

            Console.WriteLine("Sum of digits {0}", sum);
            Console.WriteLine("reversed {0}{1}{2}{3}", fourthDigits, thirdDigits, secondDigit, firstDigit);
            Console.WriteLine("last digit in front {0}{1}{2}{3}", fourthDigits, firstDigit, secondDigit, thirdDigits);
            Console.WriteLine("second and third digits exchanged {0}{1}{2}{3}", firstDigit, thirdDigits, secondDigit, fourthDigits);
        }
    }
}

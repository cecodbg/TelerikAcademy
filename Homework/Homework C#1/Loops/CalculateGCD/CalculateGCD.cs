//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm .

using System;

namespace CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {
            int nNumber;
            Console.Write("Enter N: ");
            bool isCorrectinput = int.TryParse(Console.ReadLine(), out nNumber);

            while (isCorrectinput == false || nNumber <= 0)
            {
                Console.Write("Incorrect input! Try again: ");
                isCorrectinput = int.TryParse(Console.ReadLine(), out nNumber);
            }

            int xNumber;
            Console.Write("Enter X: ");
            isCorrectinput = int.TryParse(Console.ReadLine(), out xNumber);

            while (isCorrectinput == false || xNumber <= 0)
            {
                Console.Write("Incorrect input! Try again: ");
                isCorrectinput = int.TryParse(Console.ReadLine(), out xNumber);
            }

            while (nNumber != 0 && xNumber != 0)
            {
                if (nNumber > xNumber)
                {
                    nNumber %= xNumber;
                }
                else
                {
                    xNumber %= nNumber;
                }
            }

            Console.Write("Greatest common divisor is {0}", Math.Max(nNumber, xNumber));
            Console.WriteLine();
        }
    }
}
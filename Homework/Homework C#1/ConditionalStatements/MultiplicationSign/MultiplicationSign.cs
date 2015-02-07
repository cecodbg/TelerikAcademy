// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

             if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine("0");
            }
            else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
            {
                Console.WriteLine("+");
            }
            else if ((firstNumber < 0 && secondNumber < 0) || (secondNumber < 0 && thirdNumber < 0) || (firstNumber < 0 && thirdNumber < 0))
            {
                Console.WriteLine("-");
            }
            else if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
            {
                Console.WriteLine("-");
            }
            else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
            {
                Console.WriteLine("-");
            }
          
        }
    }
}

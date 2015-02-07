// Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber < secondNumber)
            {
                Console.WriteLine("{0}, {1}", firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("{0}, {1}", secondNumber, firstNumber);
            }
        }
    }
}

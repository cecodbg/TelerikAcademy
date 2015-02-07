// Using loops write a program that converts a binary integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

using System;

namespace BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter binary integer number to convert to decimal: ");
            string binaryNum = Console.ReadLine();
            long decimalNum = 0;

            for (int i = binaryNum.Length - 1, j = 0; i >= 0; i--, j++)
            {
                decimalNum += long.Parse(binaryNum[i].ToString()) * (long)Math.Pow(2, j);
            }
            Console.WriteLine(decimalNum);
        }
    }
}

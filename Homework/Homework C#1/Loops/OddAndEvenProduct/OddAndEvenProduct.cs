// You are given n integers (given in a single line, separated by a space).
// Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
// Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.Write("Enter count of numbers: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter {0} integers separated by a space:", number);

            string inString = Console.ReadLine();
            string[] str = inString.Split(' ');
            int[] num = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                num[i] = int.Parse(str[i]);
            }

            int even = 1;
            int odd = 1;
            for (int i = 0; i < num.Length; i++)
            {
                if (i % 2 == 0)
                {
                    odd *= num[i];
                }
                else
                {
                    even *= num[i];
                }
            }

            if (odd == even)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Odd product = {0}", odd);
                Console.WriteLine("Even product = {0}", even);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Odd product = {0}", odd);
                Console.WriteLine("Even product = {0}", even);
            }
        }
    }
}



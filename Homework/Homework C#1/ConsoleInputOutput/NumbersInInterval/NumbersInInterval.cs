//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

namespace NumbersInInterval
{
    class NumbersInInterval
    {
        static void Main()
        {
            Console.Write("Enter start nuber: ");
            int startNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int endNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            string str = string.Empty;

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % 5 == 0)
                {
                    counter++; 
                    str = str + " " + i.ToString();
                    //Console.Write("{0}, ", i);
                }
            }
            Console.WriteLine("The number is {0}", counter + " ->" +  str);
        }
    }
}

// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is workings correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static void Main()
        {
            Console.WriteLine("Eneter numbers, separated by a comma: ");
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            Console.Write("Enter searched number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("The searched number appears in {0} times in this array", Counter(number, numbers));

        }

        static int Counter(int number, int[] numbers)
        {
            int count = 0;
            foreach (int num in numbers)
            {
                if (number == num)
                {
                    count++;
                }
            }
            return count;
        }

        //static int Counter(int number, int[] numbers)
        //{
        //    return numbers.Where(x => x == number)
        //                  .Count();
        //}
    }
}

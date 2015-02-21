//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeThanNeighbours
{
    class LargeThanNeighbours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter numbers, separated by a comma: ");
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            Console.Write("Enter searched position: ");
            int position = int.Parse(Console.ReadLine());

            if (GetPosition(position, numbers))
            {
                Console.WriteLine("The number of position {0} is larger than its neighbors", position);
            }
            else
            {
                Console.WriteLine("The number of the item {0} is not larger than its neighbors", position);
            }
        }

        static bool GetPosition(int position, int[] numbers)
        {
            bool isTrue = false;
            if (position > 0 && position < numbers.Length - 1)
            {
                if (numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1])
                {
                    isTrue = true;
                }
            }
            return isTrue;
        }

    }
}

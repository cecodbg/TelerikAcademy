// Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
// Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main()
        {
            Console.WriteLine("Eneter numbers, separated by a comma: ");
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.WriteLine(GetPositionInArray(numbers));
        }

        static int GetPositionInArray(int[] numbers)
        {
            int position = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                position = i;
                if (GetPosition(position, numbers))
                {
                    position = i;
                    break;
                }
                else
                {
                    position = -1;
                }
            }
            return position;
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

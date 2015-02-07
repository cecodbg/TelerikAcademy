// Write a program that compares two char arrays lexicographically (letter by letter).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class ProgramCompareCharArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter char for first Array: ");
            string[] stringFirstArray = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            char[] firstArray = new char[stringFirstArray.Length];
            for (int i = 0; i < stringFirstArray.Length; i++)
            {
                firstArray[i] = (char.Parse(stringFirstArray[i]));
            }

            Console.WriteLine("Enter char for second Array: ");
            string[] stringSecondArray = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            char[] secondArray = new char[stringSecondArray.Length];
            for (int i = 0; i < stringSecondArray.Length; i++)
            {
                secondArray[i] = (char.Parse(stringSecondArray[i]));
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("Char from first Array {0} of position {1} is equal to \nchar from second Array {2} of position {3} ", firstArray[i], i, secondArray[i], i);
                }
            }
        }
    }
}

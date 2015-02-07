//Write a program that reads two integer arrays from the console and compares them element by element

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter numbers for first Array: ");
            string[] stringFirstArray = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int[] firstArray = new int[stringFirstArray.Length];
            for (int i = 0; i < stringFirstArray.Length; i++)
            {
                firstArray[i] = (int.Parse(stringFirstArray[i]));
            }

            Console.WriteLine("Enter numbers for second Array: ");
            string[] stringSecondArray = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int[] secondArray = new int[stringSecondArray.Length];
            for (int i = 0; i < stringSecondArray.Length; i++)
            {
                secondArray[i] = (int.Parse(stringSecondArray[i]));
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("Element from first Array {0} of position {1} is equal to \nelement from second Array {2} of position {3} ", firstArray[i], i, secondArray[i], i);
                }
            }
        }
    }
}

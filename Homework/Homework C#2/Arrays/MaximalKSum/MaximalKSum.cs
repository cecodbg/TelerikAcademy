using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalKSum
{
    class MaximalKSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array lenght n: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number elements k: ");
            int kSum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array: ");
            string[] numbersArray = Console.ReadLine().Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[arrayLenght];
            for (int i = 0; i < arrayLenght; i++)
            {
                array[i] = (int.Parse(numbersArray[i]));
            }

            int sumMax = 0;
            Array.Sort(array);
            for (int i = array.Length - 1; i > array.Length - 1 - kSum; i--)
            {
                sumMax += array[i];
            }
            Console.WriteLine(sumMax);
        }
    }
}


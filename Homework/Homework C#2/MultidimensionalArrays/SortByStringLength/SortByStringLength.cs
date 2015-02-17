// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByStringLength
{
    class SortByStringLength
    {
        static void Main(string[] args)
        {
            string[] citys = {"Sofia", "Varna", "Burgas", "Ruse", "Plovdiv", "Pleven"};

            Array.Sort(citys, (x, y) => x.Length.CompareTo(y.Length));

            foreach (var item in citys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}

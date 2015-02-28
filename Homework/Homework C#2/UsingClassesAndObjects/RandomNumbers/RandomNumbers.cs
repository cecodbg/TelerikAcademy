// Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class RandomNumbers
    {
        static Random gen = new Random();

        static void Main()
        {
            Console.WriteLine(gen.Next(100, 200));
        }
    }
}

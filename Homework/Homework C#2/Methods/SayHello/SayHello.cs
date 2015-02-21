// Write a method that asks the user for his name and prints “Hello, <name>”
// Write a program to test this method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class SayHello
    {
        static void Main()
        {
            UserInput();
        }

        static void UserInput() 
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            Console.WriteLine("Helo {0}", input);
        }

    }
}

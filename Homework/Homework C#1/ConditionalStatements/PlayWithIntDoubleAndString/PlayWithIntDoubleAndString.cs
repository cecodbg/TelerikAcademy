// Write a program that, depending on the user’s choice, inputs an int, double or string variable.
// If the variable is int or double, the program increases it by one.
// If the variable is a string, the program appends * at the end.
// Print the result at the console. Use switch statement.

using System;
using System.Globalization;
using System.Threading;

namespace PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Enter 1 for int, 2 for double or 3 for string: ");
            int choice = int.Parse(Console.ReadLine());
           
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter an integer");
                    int i = int.Parse(Console.ReadLine());
                    Console.WriteLine(i += 1);
                    break;
                case 2:
                    Console.WriteLine("Please enter a double");
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine(d += 1);
                    break;
                case 3:
                    Console.WriteLine("Please enter a string");
                    string str = Console.ReadLine();
                    Console.WriteLine(str + "*");
                    break;
                default:
                    break;
            }
        }
    }
}

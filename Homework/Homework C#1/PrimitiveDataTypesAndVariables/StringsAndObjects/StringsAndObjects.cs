// Declare two string variables and assign them with Hello and World.
// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string stHello = "Hello";
            string stWorld = "World";
            object data = stHello + " " + stWorld;
            string newString = (string)data;

            Console.WriteLine(newString);
        }
    }
}

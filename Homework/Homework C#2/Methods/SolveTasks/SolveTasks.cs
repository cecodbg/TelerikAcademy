using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveTasks
{
    class SolveTasks
    {
        static void Main()
        {
            Console.WriteLine("Enter 1 to reverse the digits of a number \nEnter 2 to calculate the average of a sequence of integers \nEnter 3 to solve a linear equation a * x + b = 0");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.Write("Enter number: ");
                    string input = Console.ReadLine();
                    Reverses(input);
                    break;
                case 2: Console.Write("Enter sequence of integers, separated by a comma: ");
                    int[] numbers = Console.ReadLine()
                                           .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                           .Select(x => int.Parse(x))
                                           .ToArray();
                    while(numbers.Length <= 0)
                    {
                        Console.Write("Incorrect input! Try again: ");
                        numbers = Console.ReadLine()
                                         .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(x => int.Parse(x))
                                         .ToArray();
                    }
                        double average = numbers.Average();
                        Console.WriteLine("Average of the sequence is: {0}", average);
                    break;
                case 3: Console.Write("Enter number a (a > 0): ");
                    int a;
                    bool isCorrect = int.TryParse(Console.ReadLine(), out a);
                    while (a <= 0 || isCorrect == false)
                    {
                        Console.Write("Incorrect input! Try again: ");
                        isCorrect = int.TryParse(Console.ReadLine(), out a);
                    };
                    Console.Write("Enter number b: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("x = {0}", SolvesEquation(a, b));
                    break;
                default:
                    break;
            }
        }

        static int SolvesEquation(int a, int b)
        {
            int result = -b / a;
            return result;
        }

        static void Reverses(string input)
        {
            var reverse = input.Reverse();
            Console.WriteLine(string.Join("", reverse));
        }
    }
}

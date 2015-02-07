using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Decoding
{
    class Problem_2___Decoding
    {
        static void Main(string[] args)
        {
            int salt = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '@')
                {
                    break;
                }
                else if (char.IsLetter(input[i]))
                {
                    double number = (int)(input[i]) * salt + 1000;
                    if (i % 2 == 0)
                    {
                        number /= 100;
                        Console.WriteLine("{0:0.00}", number);
                    }
                    else
                    {
                        number *= 100;
                        Console.WriteLine(number);
                    }
                }

                else if (char.IsNumber(input[i]))
                {
                    double number2 = (int)(input[i]) + salt + 500;

                    if (i % 2 == 0)
                    {
                        number2 /= 100;
                        Console.WriteLine("{0:0.00}", number2);
                    }
                    else
                    {
                        number2 *= 100;
                        Console.WriteLine(number2);
                    }
                }
                else
                {
                    double number3 = (int)(input[i]) - salt;

                    if (i % 2 == 0)
                    {
                        number3 /= 100;
                        Console.WriteLine("{0:0.00}", number3);
                    }
                    else
                    {
                        number3 *= 100;
                        Console.WriteLine(number3);
                    }
                }
            }
        }
    }
}

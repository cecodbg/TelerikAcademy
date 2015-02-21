// Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static void Main()
        {
            Console.WriteLine("Eneter first numbers: ");
            int[] firstNumbers = Console.ReadLine()
                .Select(x => int.Parse(x.ToString()))
                .Reverse()
                .ToArray();

            Console.WriteLine("Eneter second numbers: ");
            int[] secondNumbers = Console.ReadLine()
                .Select(x => int.Parse(x.ToString()))
                .Reverse()
                .ToArray();

            Console.WriteLine(string.Join("", SumArray(firstNumbers, secondNumbers)));

        }

        static List<int> SumArray(int[] firstNumbers, int[] secondNumbers)
        {
            List<int> results = new List<int>();
            int[] copiFirstNumbers = new int[firstNumbers.Length];
            int[] copiSecondNumbers = new int[secondNumbers.Length];
            int lenght = Math.Max(firstNumbers.Length, secondNumbers.Length);
            if (firstNumbers.Length > secondNumbers.Length)
            {
                copiFirstNumbers = new int[firstNumbers.Length];
                copiSecondNumbers = new int[firstNumbers.Length];
                Array.Copy(secondNumbers, copiSecondNumbers, firstNumbers.Length -
                          (firstNumbers.Length - secondNumbers.Length));
                Array.Copy(firstNumbers, copiFirstNumbers, firstNumbers.Length);
            }
            else if (secondNumbers.Length > firstNumbers.Length)
            {
                copiFirstNumbers = new int[secondNumbers.Length];
                copiSecondNumbers = new int[secondNumbers.Length];
                Array.Copy(firstNumbers, copiFirstNumbers, secondNumbers.Length -
                    (secondNumbers.Length - firstNumbers.Length));
                Array.Copy(secondNumbers, copiSecondNumbers, secondNumbers.Length);
            }
            else
            {
                copiFirstNumbers = new int[firstNumbers.Length];
                copiSecondNumbers = new int[secondNumbers.Length];
                Array.Copy(firstNumbers, copiFirstNumbers, firstNumbers.Length);
                Array.Copy(secondNumbers, copiSecondNumbers, secondNumbers.Length);
            }
            int result = 0;
            for (int i = 0; i < lenght; i++)
            {
                for (int j = i; j < lenght; j++)
                {
                    if (result > 0)
                    {
                        if ((copiFirstNumbers[i] + copiSecondNumbers[j]) + result > 9)
                        {
                            result = (copiFirstNumbers[i] + copiSecondNumbers[j] + result) / 10;
                            results.Add((copiFirstNumbers[i] + copiSecondNumbers[j] + result) % 10);
                        }
                        else
                        {
                            results.Add(copiFirstNumbers[i] + copiSecondNumbers[j] + result);
                        }
                        if (j == lenght - 1)
                        {
                            results.Add(result);
                        }
                        break;
                    }
                    else if (copiFirstNumbers[i] + copiSecondNumbers[j] > 9)
                    {
                        result = (copiFirstNumbers[i] + copiSecondNumbers[j]) / 10;
                        results.Add((copiFirstNumbers[i] + copiFirstNumbers[j]) % 10);
                    }
                    else
                    {
                        results.Add(copiFirstNumbers[i] + copiSecondNumbers[j]);
                    }
                    break;
                }
            }
            results.Reverse();
            return results;
        }
    }
}

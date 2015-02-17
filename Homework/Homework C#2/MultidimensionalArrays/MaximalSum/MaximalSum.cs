// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter row of metrix > 3: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter column of matrix > 3: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];
            Random random = new Random();

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = random.Next(-100, 100);
                }
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("{0,5}", matrix[r, c]);
                }
                Console.WriteLine();
            }

            int result = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int r = 0; r < matrix.GetLength(0) - 2; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 2; c++)
                {
                    int sum = matrix[r, c] + matrix[r, c + 1] + matrix[r, c + 2] +
                              matrix[r + 1, c] + matrix[r + 1, c + 1] + matrix[r + 1, c + 2] +
                              matrix[r + 2, c] + matrix[r + 2, c + 1] + matrix[r + 2, c + 2];
                    if (sum > result)
                    {
                        result = sum;
                        bestRow = r;
                        bestCol = c;
                    }
                }
            }

            Console.WriteLine("Maximal sum of elements is: {0}", result);
            Console.WriteLine("{0,5}{1,5}{2,5}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            Console.WriteLine("{0,5}{1,5}{2,5}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine("{0,5}{1,5}{2,5}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        }
    }
}




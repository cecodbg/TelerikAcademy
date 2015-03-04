// Write a program that reads a text file containing a square matrix of numbers.
// Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
// The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space.
// The output should be a single number in a separate text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaximalAreaSum
{
    class MaximalAreaSum
    {
        static void Main()
        {
            string readerPath = Console.ReadLine();
            string writerPath = Console.ReadLine();
            var reader = new StreamReader(readerPath);
            var writer = new StreamWriter(writerPath);
            int[,] matrix;

            matrix = FillMatrix(reader);
            PrintMatrix(matrix);
            Console.WriteLine(FindMaximalSum(matrix, 2));
            writer.Write(FindMaximalSum(matrix, 2));
            writer.Close();
        }

        static int[,] FillMatrix(StreamReader reader)
        {
            bool isTrue = true;
            int[,] matrix = null;
            while (isTrue)
            {
                int size = int.Parse(reader.ReadLine());
                matrix = new int[size, size];

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    string[] rowReader = reader.ReadLine().Split(' ');
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = int.Parse(rowReader[col]);
                    }
                }

                if (reader.Peek() < 0)
                {
                    isTrue = false;
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static int FindMaximalSum(int[,] matrix, int size)
        {
            int sum = 0;
            int sumMax = 0;
            for (int row = 0; row < matrix.GetLength(0) - (size - 1); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - (size - 1); col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + 
                          matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > sumMax)
                    {
                        sumMax = sum;
                    }
                }
            }
            return sumMax;
        }
    }
}

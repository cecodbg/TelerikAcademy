// Write a program that fills and prints a matrix of size (n, n) as shown below:

//       a)	                  b)	              c)	            d)*
// 1   5   9	13      1   8   9   16      7   11  14  16      1   12  11  10
// 2   6   10	14      2   7   10  15      4   8   12  15      2   13  16  9
// 3   7   11	15      3   6   11  14      2   5   9   13      3   14  15  8
// 4   8   12	16      4   5   12  13      1   3   6   10      4   5   6   7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int size = GetInput();
            int[,] matrix = BuildMatrix(size);
            char choice = GetChoice();
            FillTheMatrixByChoice(choice, matrix);
            PrintMatrix(matrix);
        }

        static int GetInput()
        {
            Console.Write("Enter size of matrix: ");
            string input = Console.ReadLine();
            int size = int.Parse(input);

            return size;
        }

        static int[,] BuildMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            return matrix;
        }

        static char GetChoice()
        {
            Console.Write("Choose type of matrix(a, b, c, d): ");
            string input = Console.ReadLine();

            return input[0];
        }

        static void FillTheMatrixByChoice(char choice, int[,] matrix)
        {
            switch (choice)
            {
                case 'a':
                    FillTheMatrixA(matrix);
                    break;
                case 'b':
                    FillTheMatrixB(matrix);
                    break;
                case 'c':
                    FillTheMatrixC(matrix);
                    break;
                case 'd':
                    FillTheMatrixD(matrix);
                    break;
                default:
                    throw new NotSupportedException("Invalid choice!");
            }
        }

        static void FillTheMatrixA(int[,] matrix)
        {
            int counter = 1;

            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    matrix[r, c] = counter;
                    counter++;
                }
            }
        }

        static void FillTheMatrixB(int[,] matrix)
        {
            int counter = 1;

            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                if (c % 2 == 0)
                {
                    for (int r = 0; r < matrix.GetLength(0); r++)
                    {
                        matrix[r, c] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int r = matrix.GetLength(0) - 1; r >= 0; r--)
                    {
                        matrix[r, c] = counter;
                        counter++;
                    }
                }
            }
        }

        static void FillTheMatrixC(int[,] matrix)
        {
            int counter = 1;

            for (int r = matrix.GetLength(0) - 1; r >= 0; r--)
            {
                for (int c = 0; c < matrix.GetLength(1) - r; c++)
                {
                    matrix[r + c, c] = counter;
                    counter++;
                }
            }

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    for (int c = 0; c < matrix.GetLength(1) - r - i; c++)
                    {
                        matrix[r + c, c + r + i] = counter;
                        counter++;
                        break;
                    }
                }
            }
        }

        static void FillTheMatrixD(int[,] matrix)
        {
            int number = matrix.GetLength(0);
            if (number % 2 != 0)
            {
                matrix[(number - 1) / 2, (number - 1) / 2] = number * number;
            }

            int index = 1;
            int nam = 1;

            for (int i = 0, col = 0, row = 0; i < number - 1; col++, row++, i++)
            {
                for (int r = 0; r < number - nam; r++)
                {
                    matrix[row + r, col] = index;
                    index++;
                }
                for (int c = 0; c < number - nam; c++)
                {
                    matrix[number - 1, row + c] = index;
                    index++;
                }
                for (int c = 0; c < number - nam; c++)
                {
                    matrix[number - 1 - c, number - 1] = index;
                    index++;
                }
                for (int x = 0; x < number - nam; x++)
                {
                    matrix[row, number - 1 - x] = index;
                    index++;
                }
                number--;
                nam++;
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("{0,4}", matrix[r, c]);
                }

                Console.WriteLine();
            }
        }
    }
}

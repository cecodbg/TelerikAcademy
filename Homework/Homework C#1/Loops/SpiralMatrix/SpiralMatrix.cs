//Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.

using System;

namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            int number;

            Console.Write("Entnr number N: ");
            bool isCorrectInput = int.TryParse(Console.ReadLine(), out number);

            while (isCorrectInput == false || number == 0 || number >= 20)
            {
                Console.Write("In correct input! Try again: ");
                isCorrectInput = int.TryParse(Console.ReadLine(), out number);
            }

            int[,] matrix = new int[number, number];

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
                    matrix[row, col + r] = index;
                    index++;
                }

                for (int c = 0; c < number - nam; c++)
                {
                    matrix[row + c, number - 1] = index;
                    index++;
                }

                for (int c = 0; c < number - nam; c++)
                {
                    matrix[number - 1, number - 1 - c] = index;
                    index++;
                }

                for (int x = 0; x < number - nam; x++)
                {
                    matrix[number - 1 - x, col] = index;
                    index++;
                }
                number--;
                nam++;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}




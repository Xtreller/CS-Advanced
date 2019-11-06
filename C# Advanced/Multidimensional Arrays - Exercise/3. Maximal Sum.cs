using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            if (sizes[0] <= 3 || sizes[1] <= 3)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                int[] input = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[i, c] = input[c];
                }
            }
            int maxSum = int.MinValue;
            int row = 0;
            int col = 0;
            for (int r = 1; r < matrix.GetLength(0) - 1; r++)
            {
                for (int c = 1; c < matrix.GetLength(1) - 1; c++)
                {
                    int currentSum = matrix[r, c]
                        + matrix[r - 1, c - 1]
                        + matrix[r - 1, c]
                        + matrix[r - 1, c + 1]
                        + matrix[r, c - 1]
                        + matrix[r, c + 1]
                        + matrix[r + 1, c - 1]
                        + matrix[r + 1, c]
                        + matrix[r + 1, c + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        row = r;
                        col = c;
                    }

                }

            }
            Console.WriteLine("Sum = " + maxSum);

            Console.Write(matrix[row - 1, col - 1] + " "
                + matrix[row - 1, col] + " "
                + matrix[row - 1, col + 1]);
            Console.WriteLine();
            Console.Write(matrix[row, col - 1] + " "
                + matrix[row, col] + " "
                + matrix[row, col + 1]);
            Console.WriteLine();
            Console.Write(matrix[row + 1, col - 1] + " "
                + matrix[row + 1, col] + " "
                + matrix[row + 1, col + 1]);
            Console.WriteLine();

        }
    }
}


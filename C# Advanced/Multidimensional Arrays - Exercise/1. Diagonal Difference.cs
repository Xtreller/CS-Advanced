using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                var Filler = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[r, col] = Filler[col];
                }

            }
            int mainDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                mainDiagonal += matrix[row, row];

            }
            for (int row = 0, col = N - 1; row < N; row++, col--)
            {
                secondaryDiagonal += matrix[row, col];
            }

            Console.WriteLine(Math.Abs(mainDiagonal - secondaryDiagonal));
        }
    }
}

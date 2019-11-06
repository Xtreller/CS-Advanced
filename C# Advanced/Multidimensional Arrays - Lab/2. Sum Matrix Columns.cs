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
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                int[] elmnt = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = elmnt[c];
                }

            }
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                int sum = 0;
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    sum += matrix[r, c];
                }

                Console.WriteLine(sum);
            }

        }
    }
}

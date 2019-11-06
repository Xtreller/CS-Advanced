using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizes = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizes,sizes];
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
            int sum = matrix[0,0];
            for (int r = 0; r < matrix.GetLength(0)-1; r++)
            {
                sum += matrix[r + 1, r + 1];

            }
            Console.WriteLine(sum);

        }
    }
}

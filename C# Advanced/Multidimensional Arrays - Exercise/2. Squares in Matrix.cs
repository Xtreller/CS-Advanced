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
            char[,] matrix = new char[sizes[0], sizes[1]];
            if (sizes[0]<=2||sizes[1]<=2)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                char[] input = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Select(char.Parse)
                     .ToArray();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[i, c] = input[c];
                }
            }
            int counter = 0;
            for (int i = 0; i < sizes[0] - 1; i++)
            {
                for (int col = 0; col < sizes[1] - 1; col++)
                {
                    if (matrix[i, col].Equals(matrix[i, col+1])
                    && matrix[i, col].Equals(matrix[i+1, col])
                    && matrix[i, col].Equals(matrix[i+1, col+1]))
                    {
                        counter++;
                    }
                }

            }
            //3 4
            //A F B B
            //E Z A A
            //W J A A
            Console.WriteLine(counter);
        }
    }
}

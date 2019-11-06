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
            var matrix = new string[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0) ; i++)
            {

                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int c = 0; c < matrix.GetLength(1) ; c++)
                {

                    matrix[i, c] = input[c];

                }
            }
            while (true)
            {
                string end = Console.ReadLine();
                if (end.ToLower() == "end")
                {
                    break;
                }
                string[] operation = end.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (operation[0].ToLower() == "swap" && operation.Length == 5)
                {
                    int x1 = int.Parse(operation[1]);
                    int y1 = int.Parse(operation[2]);
                    int x2 = int.Parse(operation[3]);
                    int y2 = int.Parse(operation[4]);
                    if (x1 < 0 || x2 < 0 || y1 < 0 || y2 < 0 || x1 > sizes[0] || x2 > sizes[0] || y1 > sizes[1] || y2 > sizes[1])
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    string temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


            }


        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0) ; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write( matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}



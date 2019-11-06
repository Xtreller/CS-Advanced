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
            int[][] matrix = new int[sizes][];
            int colSize = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                int[] colmnElmnt = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                matrix[i] = new int[colmnElmnt.Length];
                for (int c = 0; c < matrix[i].Length; c++)
                {
                    matrix[i][c] = colmnElmnt[c];
                }
            }

            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "END")
                {
                    break;
                }
                string[] tokens = comand.Split();
                if (int.Parse(tokens[1]) < 0 ||
                        int.Parse(tokens[1]) >= matrix.Length
                        || int.Parse(tokens[2]) < 0
                        || int.Parse(tokens[2]) >= matrix[int.Parse(tokens[1])].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (tokens[0] == "Add")
                {
                    matrix[int.Parse(tokens[1])][int.Parse(tokens[2])] += int.Parse(tokens[3]);

                }

                if (tokens[0] == "Subtract")
                {
                    matrix[int.Parse(tokens[1])][int.Parse(tokens[2])] -= int.Parse(tokens[3]);
                }

            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }
    }
}

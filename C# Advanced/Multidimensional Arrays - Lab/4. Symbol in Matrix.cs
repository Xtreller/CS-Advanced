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
            char[,] matrix = new char[sizes,sizes];
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                string input = Console.ReadLine();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = input[c];
                }

            }
            char elementToFind = char.Parse(Console.ReadLine());
            bool elementIsExisting = false;
            int row = 0;
            int col = 0;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r,c]==elementToFind)
                    {
                        elementIsExisting = true;
                        row = r;
                        col = c;
                        Console.WriteLine($"({r}, {c})");
                        break;
                    }
                }

            }
            if (elementIsExisting == false)
            {
                Console.WriteLine($"{elementToFind} does not occur in the matrix");
            }


           
        }
    }
}

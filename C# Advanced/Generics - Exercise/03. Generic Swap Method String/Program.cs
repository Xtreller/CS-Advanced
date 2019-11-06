
using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic_methods<string> collector = new Generic_methods<string>();
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string inputItem = Console.ReadLine();
                collector.Add(inputItem);
            }
            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            collector.Replace(indexes[0], indexes[1]);
            string res = collector.ToString();
            Console.WriteLine(res);
        }

    }
}

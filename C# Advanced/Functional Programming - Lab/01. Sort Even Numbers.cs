using System;
using System.Linq;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n))
            .Where(x => x % 2 == 0)
            .OrderBy(n => n)
            .ToArray();

            Console.WriteLine(string.Join(", ",input));

        }
    }
}

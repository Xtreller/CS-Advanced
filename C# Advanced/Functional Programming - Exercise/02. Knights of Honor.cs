using System;
using System.Linq;

namespace Functional_Programing_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> Printer = delegate (string[] input)
            {
                foreach (var item in input)
                {
                    Console.WriteLine("Sir " + item);
                }
            };
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Printer(words);
        }
    }
}
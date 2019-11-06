using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double,int> dictionary = new Dictionary<double, int>();

            foreach (var item in input)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else
                {
                    dictionary.Add(item, 1);
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}

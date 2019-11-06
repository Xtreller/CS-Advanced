using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new SortedDictionary<char, int>();

            string input = Console.ReadLine();
            foreach (char item in input)
            {
                if (!collection.ContainsKey(item))
                {
                    collection.Add(item, 1);
                }
                else
                {
                    collection[item]++;
                }
            }
            foreach (var item in collection)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}


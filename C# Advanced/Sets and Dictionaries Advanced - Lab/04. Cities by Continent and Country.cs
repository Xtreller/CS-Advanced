using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> countries =
                  new Dictionary<string, Dictionary<string, List<string>>>();
            int cnt = int.Parse(Console.ReadLine());
            for (int i = 0; i < cnt; i++)
            {
                var entry = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (!countries.ContainsKey(entry[0]))
                {
                    countries.Add(entry[0], new Dictionary<string, List<string>>());
                }
                if (!countries[entry[0]].ContainsKey(entry[1]))
                {
                    countries[entry[0]][entry[1]] = new List<string>();
                }
                countries[entry[0]][entry[1]].Add(entry[2]);
            }
            foreach (var contry in countries)
            {
                Console.WriteLine($"{contry.Key}:");
                foreach (var item in contry.Value)
                {
                    Console.WriteLine($"  {item.Key} -> {string.Join(", ", item.Value)}");
                }

            }

        }
    }
}


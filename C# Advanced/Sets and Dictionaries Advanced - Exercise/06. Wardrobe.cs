using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new Dictionary<string, Dictionary<string, int>>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var dict = new Dictionary<string, int>();

                string[] entry = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string[] clothes = entry[1].Split(',', StringSplitOptions.RemoveEmptyEntries);
                if (!collection.ContainsKey(entry[0]))
                {
                    collection[entry[0]] = new Dictionary<string, int>();
                }
                foreach (var item in clothes)
                {
                    if (!collection[entry[0]].ContainsKey(item))
                    {
                        collection[entry[0]].Add(item, 0);

                    }
                    collection[entry[0]][item]++;
                }
            }
            string[] searchedClothing = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in collection)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var clothing in item.Value)
                {
                    if (searchedClothing[0] == item.Key && searchedClothing[1] == clothing.Key)
                    {

                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");

                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} ");
                    }
                }

            }

        }
    }
}


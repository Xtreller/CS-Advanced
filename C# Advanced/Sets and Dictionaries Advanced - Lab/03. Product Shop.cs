using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string,double>> shops =
                new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string Revision = Console.ReadLine();
                if (Revision=="Revision")
                {
                    break;
                }
                var entry = Revision.Split(',', StringSplitOptions.RemoveEmptyEntries);
                if (!shops.ContainsKey(entry[0]))
                {
                    shops.Add(entry[0], new Dictionary<string, double>());
                }
                if (!shops[entry[0]].ContainsKey(entry[1]))
                {
                    shops[entry[0]].Add(entry[1], 0);
                }
                shops[entry[0]][entry[1]] = double.Parse(entry[2]);
            }
            foreach (var shop in shops)
            {
                Console.WriteLine(shop.Key+ "->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product:{product.Key}, Price: {product.Value}");

                }
            }
           
        }
    }
}


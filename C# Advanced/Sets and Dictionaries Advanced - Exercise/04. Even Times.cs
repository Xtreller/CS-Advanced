using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var collection = new Dictionary<string, int>();

            for (int i = 0; i < count; i++)
            {
                string Key = Console.ReadLine();
                if (!collection.ContainsKey(Key))
                {
                    collection.Add(Key, 1);
                }
                else
                {
                    collection[Key]++;
                }
            }
            foreach (var item in collection)
            {
                if (item.Value==2)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}


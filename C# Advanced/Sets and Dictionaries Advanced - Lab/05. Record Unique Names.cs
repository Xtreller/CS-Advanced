using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());
            var hash = new HashSet<string>();
            for (int i = 0; i < cnt; i++)
            {
                string entry = Console.ReadLine();
                hash.Add(entry);
            }
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}


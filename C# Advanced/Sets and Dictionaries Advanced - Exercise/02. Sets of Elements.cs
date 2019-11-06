using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
           
            var m = new HashSet<string>();
            var n = new HashSet<string>();
            var res = new HashSet<string>();

            for (int i = 0; i <arr1[0]; i++)
            {
                string entry = Console.ReadLine();
                m.Add(entry);
            }
            for (int i = 0; i < arr1[1]; i++)
            {
                string entry = Console.ReadLine();
                n.Add(entry);
            }
            foreach (var item in m)
            {
                if (n.Contains(item))
                {
                    res.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",res));

        }
    }
}


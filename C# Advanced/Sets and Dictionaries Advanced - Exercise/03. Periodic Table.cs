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
            var arr1 = new List<string>();


            for (int i = 0; i < count; i++)
            {
                var entry = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in entry)
                {
                    arr1.Add(item); 
                }
            }

            var set = new SortedSet<string>(arr1);
            Console.WriteLine(string.Join(" ",set));
        }
    }
}


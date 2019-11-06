using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Even_Or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] borders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string filter = Console.ReadLine();


            List<long> allNumbers = new List<long>();
            for (int i = borders[0]; i <= borders[1]; i++)
            {
                allNumbers.Add(i);
            }
            Predicate<long> even = x => { return x % 2 == 0; };
            Predicate<long> odd = x => { return x % 2 != 0; };

            //List<long> result
            if (filter.ToLower() == "even")
            {

                Console.WriteLine(string.Join(" ", allNumbers.FindAll(even)));
            }
            if (filter.ToLower() == "odd")
            {

                Console.WriteLine(string.Join(" ", allNumbers.FindAll(odd)));
            }
        }
    }
}

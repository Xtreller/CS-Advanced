using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToList();
            int divider = int.Parse(Console.ReadLine());
            Predicate<int> divisible = x => { return x % divider != 0; };
            Console.WriteLine(string.Join(" ",numbers.FindAll(divisible)));



        }

    }
}

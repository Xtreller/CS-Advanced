using System;
using System.Linq;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => x.Length <= n).ToArray();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}

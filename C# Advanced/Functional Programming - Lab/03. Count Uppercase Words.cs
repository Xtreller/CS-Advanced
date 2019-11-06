using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(n => n[0] == n.ToUpper()[0]).ToArray();
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}

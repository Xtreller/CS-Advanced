
using System;

namespace Generics_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);

            }

            string res = box.ToString();

            Console.WriteLine(res);
        }

    }
}

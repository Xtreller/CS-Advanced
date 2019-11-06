using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]== '(')
                {
                    stack.Push(i);
                }
                if (input[i]==')')
                {
                    int start = stack.Pop();
                    Console.WriteLine(input.Substring(start, i - start + 1));
                }
            }

        }
    }
}

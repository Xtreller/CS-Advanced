using System;
using System.Collections.Generic;

namespace CS_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split();
            var stack = new Stack<string>();
            double result = 0;
            foreach (var item in inputArray)
            {
                stack.Push(item);
            }
            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    while (stack.Count != 0)
                    {

                        result += double.Parse(stack.Pop());
                    }
                    Console.WriteLine("Sum: " + result);
                    break;
                }
                string[] tokens = input.Split();
                if (tokens[0].ToLower() == "add")
                {
                    stack.Push(tokens[1]);
                    stack.Push(tokens[2]);
                }
                if (tokens[0].ToLower() == "remove")
                {
                    if (int.Parse(tokens[1]) >= stack.Count)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < int.Parse(tokens[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
        }
    }
}

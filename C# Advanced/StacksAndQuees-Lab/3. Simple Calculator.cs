using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split();
            var stack = new Stack<string>(inputArray.Reverse());
            double result = 0;
            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string operand = stack.Pop();
                int second = int.Parse(stack.Pop());

                switch (operand)
                {
                    case "+":
                        stack.Push((first + second).ToString());
                        break;  
                    case "-":
                        stack.Push((first - second).ToString());
                        break;  
                    default:
                        break;
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}

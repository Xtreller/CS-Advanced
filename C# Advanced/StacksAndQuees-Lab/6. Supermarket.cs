using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    continue;
                }
                else if (name == "End")
                {
                    Console.WriteLine(queue.Count + " people remaining.");
                    break;
                }
                else
                {
                    queue.Enqueue(name);
                }

            }

        }
    }
}

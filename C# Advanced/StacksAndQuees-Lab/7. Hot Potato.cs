using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(input);
            while (queue.Count != 1)
            {
                for (int i = 1; i < n; i++)    
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");

            }

            Console.WriteLine($"Last is {queue.Dequeue()}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace CS_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int cnt = 0;
            while (true)
            {
                string vehicle = Console.ReadLine();
                if (vehicle == "end")
                {
                    break;
                }
                else if (vehicle == "green")
                {

                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count>0)
                        {

                            Console.WriteLine(queue.Dequeue() + " passed!");
                            cnt++;
                        }
                    }
                    

                }
                else
                {
                    queue.Enqueue(vehicle);
                }
            }
            Console.WriteLine(cnt + " cars passed the crossroads.");
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var hash = new HashSet<string>();
            while (true)
            {
                string[] entry = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
                if (entry[0] == "END")
                {
                    break;
                }
                if (entry[0] == "OUT" && hash.Contains(entry[1]))
                {
                    hash.Remove(entry[1]);
                }
                if (entry[0] == "IN")
                {
                    hash.Add(entry[1]);
                }

            }
            if (hash.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {

                foreach (var item in hash)
                {
                    Console.WriteLine(item);
                }
            }


        }
    }
}


using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new List<string>();
            var hash = new HashSet<string>();

            while (true)
            {
                string entry = Console.ReadLine();
                if (entry == "PARTY")
                {

                    while (true)
                    {
                        entry = Console.ReadLine();
                        if (hash.Contains(entry))
                        {
                            hash.Remove(entry);
                        }
                        if (entry == "END")
                        {
                            Console.WriteLine(hash.Count);
                            foreach (var item in hash)
                            {
                                Console.WriteLine(item);
                            }
                            return;

                        }
                    }

                }
                

                hash.Add(entry);

            }

            


        }
    }
}


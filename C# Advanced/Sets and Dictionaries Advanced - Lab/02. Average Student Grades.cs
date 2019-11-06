using System;
using System.Linq;
using System.Collections.Generic;

namespace Sets_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var cnt = int.Parse(Console.ReadLine());


            Dictionary<string, List<double>> dictionary = new Dictionary<string, List<double>>();

            for (int i = 0; i < cnt; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (dictionary.ContainsKey(input[0]))
                {
                    dictionary[input[0]].Add(double.Parse(input[1]));
                }
                else
                {
                    dictionary.Add(input[0], new List<double> { double.Parse(input[1]) });
                }

            }
            foreach (var item in dictionary)
            {
                var studentsGrades = item.Value;
                Console.Write($"{item.Key} -> ");
                foreach (var grade in studentsGrades)
                {
                    Console.Write($"{ grade:f2} ");

                }
                Console.WriteLine($"(avg: {item.Value.Average():f2})");

            }
        }
    }
}


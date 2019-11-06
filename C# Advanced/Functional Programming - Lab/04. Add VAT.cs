using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> VAT = n => n += n * 0.2;
            double[] input = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(VAT).ToArray();

            foreach (var item in input)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}

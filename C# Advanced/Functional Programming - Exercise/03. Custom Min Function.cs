using System;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int> Printer = x => Console.WriteLine(x);
            int min = int.MaxValue;
            Func<int[], int> MinValue = delegate (int[] values)
                {
                    foreach (var item in values)
                    {
                        if (item < min)
                        {
                            min = item;
                        }
                    }
                    return min;
                };
            int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Printer(MinValue(input));
        }
    }
}

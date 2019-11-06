using System;
using System.Linq;

namespace Aplied_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "end")
                {
                    break;
                }
                if (comand == "add")
                {

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = add(numbers[i]); 
                    }
                    
                }
                if (comand == "subtract")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = subtract(numbers[i]);  
                    }
                }
                if (comand == "multiply")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = multiply(numbers[i]);
                    }
                }
                if (comand == "print")
                {
                    Console.WriteLine(string.Join(" ",numbers));
                    return;
                }
            }

        }
        public static int add(int p) => p += 1;
        public static int subtract(int p) => p -= 1;
        public static int multiply(int p) => p *= 2;




    }
}

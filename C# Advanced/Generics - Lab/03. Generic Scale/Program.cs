using System;

namespace StartUP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Box<int> box = new Box<int>();

            //box.Add(1);
            //box.Add(2);
            //box.Add(3);
            //Console.WriteLine(box.Remove());
            //box.Add(4);
            //box.Add(5);
            //Console.WriteLine(box.Remove());

            string[] strings = ArrayCreator.Create(5, "Pesho");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
            int[] integ = ArrayCreator.Create(10, 33);
            foreach (var item in integ)
            {
                Console.WriteLine(item);
            }
        }
    }
}

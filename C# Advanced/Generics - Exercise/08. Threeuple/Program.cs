
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] personInfo = Console.ReadLine().Split();
            string[] secondLine = Console.ReadLine().Split();
            string[] thirdLine = Console.ReadLine().Split();

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 3; i < personInfo.Length; i++)
            {
                stringBuilder.Append(personInfo[i]+ " ");
            }
            bool ToF;
            if (secondLine[2].ToLower()=="drunk")
            {
                ToF = true;
            }
            else
            {
                ToF = false;
            }
            Tuple<string, string,string> person = new Tuple<string, string,string>(personInfo[0]+" "+personInfo[1],personInfo[2],stringBuilder.ToString());
            Tuple<string, int, bool> beer = new Tuple<string, int, bool>(secondLine[0], int.Parse(secondLine[1]),ToF);
            Tuple<string, double,string > numbers = new Tuple<string, double,string>(thirdLine[0], double.Parse(thirdLine[1]),thirdLine[2]);

            Console.WriteLine(person.GetInfo());
            Console.WriteLine(beer.GetInfo());
            Console.WriteLine(numbers.GetInfo());

        }

    }
}

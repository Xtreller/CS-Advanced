using DefiningClases;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();

            //person.Name = Console.ReadLine();
            //person.Age = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{person.Name} \n{person.Age}");
            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //var personCtor = new Person(age);
            //var personCtorName = new Person(name, age);
            //Console.WriteLine(personCtor.Name);
            //Console.WriteLine(personCtor.Age);
            //Console.WriteLine(personCtorName.Name);
            //Console.WriteLine(personCtorName.Age);

            //FamilyMembers+OldestMember
            //var family = new Family();
            //int membersCount = int.Parse(Console.ReadLine());
            //for (int i = 0; i < membersCount; i++)
            //{
            //    string[] currentMember = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            //    string name = currentMember[0];
            //    int age = int.Parse(currentMember[1]);

            //    family.AddMember(name,age);

            //}
            //Console.WriteLine();
            //Console.WriteLine(family.GetOldestMember());
            //Console.WriteLine();
            //foreach (var item in family.GetElder())
            //{
            //    Console.WriteLine(string.Join(" ",item.Key,item.Value));
            ////}
            ///dateModifier
            //string startDate = Console.ReadLine();
            //string endDate = Console.ReadLine();

            //var daysDifference = new DateModifier();

            //Console.WriteLine(Math.Abs(daysDifference.GetDateDifference(startDate,endDate)));
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < carsCount; i++)
            {
                Car car = new Car();
                string carEntry = Console.ReadLine();
                car.Model = carEntry.Split()[0];
                car.FuelAmount = double.Parse(carEntry.Split()[1]);
                car.FuelConsumptionPerKilometer = double.Parse(carEntry.Split()[2]);
                car.Travelleddistance = 0;

                cars.Add(new Car(car.Model, car.FuelAmount, car.FuelConsumptionPerKilometer, car.Travelleddistance));

            }
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0].ToLower() == "end")
                {
                    break;
                }

                string carModel = input[1];
                double distance = double.Parse(input[2]);

                Car car = cars.Find(c => c.Model == carModel);
                car.Drive(distance);

            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }
       
        


    }
}


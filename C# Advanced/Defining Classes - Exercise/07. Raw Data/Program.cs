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

            List<RawData> cars = new List<RawData>();
            int carsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsCount; i++)
            {
                string[] carEntry = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                //"{model} 
                //{ engineSpeed} {enginePower} 
                //{ cargoWeight} {cargoType} 
                //{ tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}
                string model = carEntry[0];
                int speed = int.Parse(carEntry[1]);
                int power = int.Parse(carEntry[2]);
                int weight = int.Parse(carEntry[3]);
                string cargoType = carEntry[4];

                var engine = new Engine(speed, power);
                var cargo = new Cargo(weight, cargoType);


                var tire = new Tire[4]
                {
                        new Tire(double.Parse(carEntry[5]),int.Parse(carEntry[6])),
                        new Tire(double.Parse(carEntry[7]),int.Parse(carEntry[8])),
                        new Tire(double.Parse(carEntry[9]),int.Parse(carEntry[10])),
                        new Tire(double.Parse(carEntry[11]),int.Parse(carEntry[12]))
                };
                RawData car = new RawData(model, engine, cargo, tire);
                cars.Add(car);

            }
            string type = Console.ReadLine();
            if (type.ToLower() == "fragile")
            {
                foreach (var car in cars.Where(t => t.Cargo.Type == type))
                {
                    bool pressureCheck = false;

                    for (int i = 0; i < car.Tires.Length; i++)
                    {
                        if (car.Tires[i].Pressure<1)
                        {
                            pressureCheck = true;
                            continue;
                        }
                    }
                    if (pressureCheck)
                    {
                        Console.WriteLine(car.Model);
                    }                    

                }

            }
            else
            {
                foreach (var car in cars.Where(t => t.Cargo.Type == type))
                {
                    if (car.Engine.Power>250)
                    {
                        Console.WriteLine(car.Model);
                    }

                }
            }
            foreach (var car in cars)
            {
                //    car.FuelQuantity -= (20 * car.FuelConsumption);
                //    if (car.Year >= 2017 && car.Engine.HorsePower > 330)
                //    {
                //        double pressureSum = 0;
                //        foreach (var item in car.Tire)
                //        {
                //            pressureSum += item.Pressure;
                //        }
                //        if (pressureSum > 9 && pressureSum < 10)
                //        {

                //            Console.WriteLine($"Make: {car.Make}");
                //            Console.WriteLine($"Model: {car.Model}");
                //            Console.WriteLine($"Year: {car.Year}");
                //            Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                //            Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");

                //        }


            }

        }


    }
}


using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClases
{
    class Car
    {
        private string model;
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }

        public double Travelleddistance { get; set; }

        List<Car> list = new List<Car>();
        public Car()
        {

        }
        public Car(string model , double fuelAmount ,double fuelConsumption ,double travelDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumption;
           
        }
        public void Drive( double traveledKilometers)
        {
            double usedFuel = traveledKilometers * FuelConsumptionPerKilometer;
            if (usedFuel <=  FuelAmount)
            {
                Travelleddistance += traveledKilometers;
                FuelAmount -= usedFuel;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {Travelleddistance}";
        }









    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClases
{
    class RawData
    {
        private string model;
        public string Model { get; set; }
        private Engine engine;
        public Engine Engine { get; set; }
        private Cargo cargo;
        public Cargo Cargo { get; set; }
                private Tire[] tires;
        public Tire[] Tires { get; set; }
        public RawData()
        {

        }
        public RawData(string model ,Engine engine,Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
           

        }


    }
    class Engine
    {
        private int speed;
        private int power;
        public int Speed { get; set; }
        public int Power { get; set; }
        public Engine()
        {

        }
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }

    }
    class Cargo
    {
        private int weight;
        private string type;

        public int Weight { get; set; }
        public string Type { get; set; }

        public Cargo()
        {

        }
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
    class Tire
    {
        private double pressure;
        private int year;

        public double Pressure { get; set; }

        public int Year { get; set; }
        public Tire()
        {

        }
        public Tire(double pressure, int year)
        {
            this.Pressure = pressure;
            this.Year = year;
        }

    }
}

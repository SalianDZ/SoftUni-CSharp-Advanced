using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        private Engine engine;

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        private Tire[] tires;

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        public Car(string make, string model, int year)
            : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
           : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,
            Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        //•	Make: string
        public string Make { get; set; }
        //•	Model: string
        public string Model { get; set; }
        //•	Year: int
        public int Year { get; set; }
        //•	FuelQuantity: double
        public double FuelQuantity { get; set; }
        //•	FuelConsumption: double
        public double FuelConsumption { get; set; }

        //•	Drive(double distance): void

        public void Drive(double distance)
        {
            //Car fuel quantity minus the distance
            //multiplied by the car fuel consumption
            //is bigger than zero.

            double capacity = FuelQuantity - (distance * FuelConsumption);
            if (capacity > 0)
            {
                //The result of the multiplication between the distance and the fuel consumption.
                FuelQuantity = capacity;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                return;
            }
        }

        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}";
        }
    }
}
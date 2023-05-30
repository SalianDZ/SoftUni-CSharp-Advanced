using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            double distance = 20.0;

            string input;

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] commandArgs = input.Split(' ');

                Tire[] fourTires = new Tire[4]
                {
                        new Tire(int.Parse(commandArgs[0]), double.Parse(commandArgs[1])),
                        new Tire(int.Parse(commandArgs[2]), double.Parse(commandArgs[3])),
                        new Tire(int.Parse(commandArgs[4]), double.Parse(commandArgs[5])),
                        new Tire(int.Parse(commandArgs[6]), double.Parse(commandArgs[7])),
                };

                tires.Add(fourTires);
            }

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] commandArgs = input.Split(' ');

                int horsePower = int.Parse(commandArgs[0]);
                double cubicCapacity = double.Parse(commandArgs[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(engine);
            }

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] commandArgs = input.Split(' ');
                //{make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}
                Car car = new Car
                    (commandArgs[0], commandArgs[1],
                    int.Parse(commandArgs[2]), int.Parse(commandArgs[3]),
                    int.Parse(commandArgs[4]), engines[int.Parse(commandArgs[5])],
                    tires[int.Parse(commandArgs[6])]);

                bool isWantedCar = IsWantedCar(car);

                if (isWantedCar)
                {
                    car.Drive(distance);
                }

                if (car.FuelQuantity != int.Parse(commandArgs[3]))
                {
                    cars.Add(car);
                }
            }

            PrintSpecialCar(cars);

        }
        public static bool IsWantedCar(Car car)
        {
            return
            (car.Year >= 2017) &&
            (car.Engine.HorsePower >= 330) &&
            car.Tires.Select(x => x.Pressure).Sum() >= 9 &&
            car.Tires.Select(x => x.Pressure).Sum() <= 10;
        }

        public static void PrintSpecialCar(List<Car> cars)
        {
            foreach (var specialCar in cars)
            {
                Console.WriteLine($"Make: {specialCar.Make}\nModel: {specialCar.Model}" +
                    $"\nYear: {specialCar.Year}\nHorsePowers: {specialCar.Engine.HorsePower}" +
                    $"\nFuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }
}
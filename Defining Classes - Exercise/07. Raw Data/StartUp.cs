using System;

namespace RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new(
                    tokens[0],
                    int.Parse(tokens[1]),
                    int.Parse(tokens[2]),
                    int.Parse(tokens[3]),
                    tokens[4],
                    double.Parse(tokens[5]),
                    int.Parse(tokens[6]),
                    double.Parse(tokens[7]),
                    int.Parse(tokens[8]),
                    double.Parse(tokens[9]),
                    int.Parse(tokens[10]),
                    double.Parse(tokens[11]),
                    int.Parse(tokens[12])
                    );

                cars.Add(car); 
            }

            string command = Console.ReadLine();

            string[] filteredModels;

            if (command == "fragile")
            {
                filteredModels = cars.Where(c => c.Cargo.Type == "fragile"
                && c.Tires.Any(t => t.Pressure < 1)).Select(c => c.Model).ToArray();
            }
            else
            {
                filteredModels = cars.Where(c => c.Cargo.Type == "flammable"
                && c.Engine.Power > 250).Select(c => c.Model).ToArray();
            }

            Console.WriteLine(string.Join(Environment.NewLine, filteredModels));
        }
    }
}
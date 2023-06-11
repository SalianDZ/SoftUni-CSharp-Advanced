using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<double> water = new Queue<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));
            Dictionary<string, int> products = new Dictionary<string, int>();
            products.Add("Croissant", 0);
            products.Add("Muffin", 0);
            products.Add("Baguette", 0);
            products.Add("Bagel", 0);

            while (water.Count > 0 && flour.Count > 0)
            {
                double currentWater = water.Peek();
                double currentFlour = flour.Peek();
                double waterPercentage = (currentWater * 100) / (currentWater + currentFlour);
                double flourPercentage = 100 - waterPercentage;

                if (waterPercentage == 50 && flourPercentage == 50)
                {
                    products["Croissant"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if (waterPercentage == 40 && flourPercentage == 60)
                {
                    products["Muffin"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if (waterPercentage == 30 && flourPercentage == 70)
                {
                    products["Baguette"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if (waterPercentage == 20 && flourPercentage == 80)
                {
                    products["Bagel"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else
                {
                    double neededAmount = currentFlour - currentWater;
                    flour.Pop();
                    flour.Push(neededAmount);
                    products["Croissant"]++;
                    water.Dequeue();
                }
            }

            foreach (var product in products.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }

            if (water.Count <= 0)
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {string.Join(", ", water)}");
            }

            if (flour.Count <= 0)
            {
                Console.WriteLine("Flour left: None");
            }
            else
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
            }
        }
    }
}

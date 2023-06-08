using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master_dotnet_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTiles = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> greyTiles = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Dictionary<string, int> counters = new Dictionary<string, int>();
            counters.Add("Sink", 0);
            counters.Add("Oven", 0);
            counters.Add("Countertop", 0);
            counters.Add("Wall", 0);
            counters.Add("Floor", 0);

            while (whiteTiles.Count > 0 && greyTiles.Count > 0)
            {
                int currentWhiteTile = whiteTiles.Peek();
                int currentGreyTile = greyTiles.Peek();
                int sum = currentWhiteTile + currentGreyTile;

                if (sum == 40)
                {
                    whiteTiles.Pop();
                    greyTiles.Dequeue();
                    if (currentGreyTile == currentWhiteTile)
                    {
                        counters["Sink"]++;
                        continue;
                    }
                    whiteTiles.Push(currentWhiteTile / 2);
                    greyTiles.Enqueue(currentGreyTile);
                }
                else if (sum == 50)
                {
                    whiteTiles.Pop();
                    greyTiles.Dequeue();
                    if (currentGreyTile == currentWhiteTile)
                    {
                        counters["Oven"]++;
                        continue;
                    }
                    whiteTiles.Push(currentWhiteTile / 2);
                    greyTiles.Enqueue(currentGreyTile);
                }
                else if (sum == 60)
                {
                    whiteTiles.Pop();
                    greyTiles.Dequeue();
                    if (currentGreyTile == currentWhiteTile)
                    {
                        counters["Countertop"]++;
                        continue;
                    }
                    whiteTiles.Push(currentWhiteTile / 2);
                    greyTiles.Enqueue(currentGreyTile);
                }
                else if (sum == 70)
                {
                    whiteTiles.Pop();
                    greyTiles.Dequeue();
                    if (currentGreyTile == currentWhiteTile)
                    {
                        counters["Wall"]++;
                        continue;
                    }
                    whiteTiles.Push(currentWhiteTile / 2);
                    greyTiles.Enqueue(currentGreyTile);
                }
                else
                {
                    whiteTiles.Pop();
                    greyTiles.Dequeue();
                    if (currentGreyTile == currentWhiteTile)
                    {
                        counters["Floor"]++;
                        continue;
                    }
                    whiteTiles.Push(currentWhiteTile / 2);
                    greyTiles.Enqueue(currentGreyTile);
                }
            }

            if (whiteTiles.Count <= 0 && greyTiles.Count <= 0)
            {
                Console.WriteLine("White tiles left: none");
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {

                if (whiteTiles.Count > 0)
                {
                    Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
                }
                else
                {
                    Console.WriteLine("White tiles left: none");
                }

                if (greyTiles.Count > 0)
                {
                    Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
                }
                else
                {
                    Console.WriteLine("Grey tiles left: none");
                }
            }

            foreach (var counter in counters.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Where(x => x.Value > 0))
            {
                Console.WriteLine($"{counter.Key}: {counter.Value}");
            }

        }
    }
}

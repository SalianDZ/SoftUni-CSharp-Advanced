using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _01._Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Dictionary<string, int> swords = new Dictionary<string, int>();
            swords.Add("Gladius", 0);
            swords.Add("Shamshir", 0);
            swords.Add("Katana", 0);
            swords.Add("Sabre", 0);
            swords.Add("Broadsword", 0);
            int count = 0;

            while (steel.Count > 0 && carbon.Count > 0)
            {
                int currentSteel = steel.Peek();
                int currentCarbon = carbon.Peek();
                int sum = currentCarbon + currentSteel;

                if (sum == 70)
                {
                    swords["Gladius"]++;
                    count++;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (sum == 80)
                {
                    swords["Shamshir"]++;
                    count++;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (sum == 90)
                {
                    swords["Katana"]++;
                    count++;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (sum == 110)
                {
                    swords["Sabre"]++;
                    count++;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (sum == 150)
                {
                    swords["Broadsword"]++;
                    count++;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else
                {
                    steel.Dequeue();
                    carbon.Pop();
                    carbon.Push(currentCarbon + 5);
                }   
            }

            if (swords.Any(x => x.Value >= 1))
            {
                Console.WriteLine($"You have forged {count} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if (steel.Count > 0)
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }

            if (carbon.Count > 0)
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }

            foreach (var sword in swords.Where(x => x.Value > 0).OrderBy(x => x.Key))
            {
                Console.WriteLine($"{sword.Key}: {sword.Value}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01._Birthday_Celebration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> guests = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> plates = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int leftFood = 0;
            int platesCounter = 0;

            while (guests.Count > 0 && plates.Count > 0)
            {
                int currentGuest = guests.Peek();
                int currentPlate = plates.Peek();

                if (currentPlate - currentGuest >= 0)
                {
                    leftFood += currentPlate - currentGuest;
                    plates.Pop();
                    platesCounter++;
                    guests.Dequeue();
                }
                else
                {
                    plates.Pop();
                    platesCounter++;
                    currentGuest -= currentPlate;
                    guests.Dequeue();
                    guests.Enqueue(currentGuest);
                    int currentCount = guests.Count;
                    for (int i = 0; i < currentCount; i++)
                    {
                        if (i == guests.Count - 1)
                        {
                            break;
                        }
                        int temp = guests.Peek();
                        guests.Dequeue();
                        guests.Enqueue(temp);
                    }
                }
            }

            if (guests.Count > 0)
            {
                Console.WriteLine($"Guests: {string.Join(" ", guests)}");
            }
            else
            {
                Console.WriteLine($"Plates: {string.Join(" ", plates)}");
            }
            Console.WriteLine($"Wasted grams of food: {leftFood}");
        }
    }
}

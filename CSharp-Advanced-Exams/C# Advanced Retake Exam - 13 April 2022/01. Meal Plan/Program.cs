using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace _01._Meal_Plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> dishes = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Stack<int> caloriesPerDay = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int leftOverCalories = 0;
            int dishCounter = 0;

            while (dishes.Count > 0 && caloriesPerDay.Count > 0)
            {
                int currentDayCalories = caloriesPerDay.Peek();

                while (currentDayCalories > 0)
                {
                    if (dishes.Count <= 0)
                    {
                        break;
                    }
                    string currentDish = dishes.Peek();
                    int currentCalories = 0;

                    if (currentDish == "salad")
                    {
                        currentCalories = 350;
                        if (currentDayCalories - currentCalories >= 0)
                        {
                            currentDayCalories -= currentCalories;
                            dishes.Dequeue();
                            dishCounter++;
                            continue;
                        }
                        else if (currentDayCalories - currentCalories < 0)
                        {
                            leftOverCalories = Math.Abs(currentDayCalories - currentCalories);
                            caloriesPerDay.Pop();
                            dishes.Dequeue();
                            dishCounter++;
                            if (caloriesPerDay.Count <= 0)
                            {
                                break;
                            }
                            currentDayCalories = caloriesPerDay.Peek();
                            currentDayCalories -= leftOverCalories;
                            caloriesPerDay.Pop();
                            caloriesPerDay.Push(currentDayCalories);
                            if (caloriesPerDay.Count > 0)
                            {
                                currentDayCalories = caloriesPerDay.Peek();
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else if (currentDish == "soup")
                    {
                        currentCalories = 490;
                        if (currentDayCalories - currentCalories >= 0)
                        {
                            dishes.Dequeue();
                            currentDayCalories -= currentCalories;
                            dishCounter++;
                            continue;
                        }
                        else if (currentDayCalories - currentCalories < 0)
                        {
                            leftOverCalories = Math.Abs(currentDayCalories - currentCalories);
                            caloriesPerDay.Pop();
                            dishes.Dequeue();
                            dishCounter++;
                            if (caloriesPerDay.Count <= 0)
                            {
                                break;
                            }
                            currentDayCalories = caloriesPerDay.Peek();
                            currentDayCalories -= leftOverCalories;
                            caloriesPerDay.Pop();
                            caloriesPerDay.Push(currentDayCalories);
                            if (caloriesPerDay.Count > 0)
                            {
                                currentDayCalories = caloriesPerDay.Peek();
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else if (currentDish == "pasta")
                    {
                        currentCalories = 680;
                        if (currentDayCalories - currentCalories >= 0)
                        {
                            dishes.Dequeue();
                            dishCounter++;
                            currentDayCalories -= currentCalories;
                            continue;
                        }
                        else if (currentDayCalories - currentCalories < 0)
                        {
                            leftOverCalories = Math.Abs(currentDayCalories - currentCalories);
                            caloriesPerDay.Pop();
                            dishes.Dequeue();
                            dishCounter++;
                            if (caloriesPerDay.Count <= 0)
                            {
                                break;
                            }
                            currentDayCalories = caloriesPerDay.Peek();
                            currentDayCalories -= leftOverCalories;
                            caloriesPerDay.Pop();
                            caloriesPerDay.Push(currentDayCalories);
                            if (caloriesPerDay.Count > 0)
                            {
                                currentDayCalories = caloriesPerDay.Peek();
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else if (currentDish == "steak")
                    {
                        currentCalories = 790;
                        if (currentDayCalories - currentCalories >= 0)
                        {
                            dishes.Dequeue();
                            dishCounter++;
                            currentDayCalories -= currentCalories;
                            continue;
                        }
                        else if (currentDayCalories - currentCalories < 0)
                        {
                            leftOverCalories = Math.Abs(currentDayCalories - currentCalories);
                            caloriesPerDay.Pop();
                            dishes.Dequeue();
                            dishCounter++;
                            if (caloriesPerDay.Count <= 0)
                            {
                                break;
                            }
                            currentDayCalories = caloriesPerDay.Peek();
                            currentDayCalories -= leftOverCalories;
                            caloriesPerDay.Pop();
                            caloriesPerDay.Push(currentDayCalories);
                            if (caloriesPerDay.Count > 0)
                            {
                                currentDayCalories = caloriesPerDay.Peek();
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }


            if (dishes.Count <= 0)
            {
                Console.WriteLine($"John had {dishCounter} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", caloriesPerDay)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {dishCounter} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", dishes)}.");
            }
        }
    }
}

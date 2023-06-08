using System.ComponentModel;

Queue<int> coffee = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Stack<int> milk = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Dictionary<string, int> counters = new();
counters.Add("Cortado", 0);
counters.Add("Espresso", 0);
counters.Add("Capuccino", 0);
counters.Add("Americano", 0);
counters.Add("Latte", 0);


while (coffee.Count > 0 && milk.Count > 0)
{
    int currentCoffee = coffee.Peek();
    int currentMilk = milk.Peek();
    int sum = currentCoffee + currentMilk;

    if (sum == 50)
    {
        counters["Cortado"]++;
        coffee.Dequeue();
        milk.Pop();
    }
    else if (sum == 75)
    {
        counters["Espresso"]++;
        coffee.Dequeue();
        milk.Pop();
    }
    else if (sum == 100)
    {
        counters["Capuccino"]++;
        coffee.Dequeue();
        milk.Pop();
    }
    else if (sum == 150)
    {
        counters["Americano"]++;
        coffee.Dequeue();
        milk.Pop();
    }
    else if (sum == 200)
    {
        counters["Latte"]++;
        coffee.Dequeue();
        milk.Pop();
    }
    else
    {
        coffee.Dequeue();
        milk.Pop();
        milk.Push(currentMilk - 5);
    }
}

if (coffee.Count <= 0 && milk.Count <= 0)
{
    Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
    Console.WriteLine("Coffee left: none");
    Console.WriteLine("Milk left: none");
}
else
{
    Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");

    if (coffee.Count > 0)
    {
        Console.WriteLine($"Coffee left: {string.Join(", ", coffee)}");
    }
    else
    {
        Console.WriteLine("Coffee left: none");
    }

    if (milk.Count > 0)
    {
        Console.WriteLine($"Milk left: {string.Join(", ", milk)}");
    }
    else
    {
        Console.WriteLine("Milk left: none");
    }
}

foreach (var counter in counters.OrderBy(x => x.Value).ThenByDescending(x =>x.Key).Where(x => x.Value > 0))
{
    Console.WriteLine($"{counter.Key}: {counter.Value}");
}

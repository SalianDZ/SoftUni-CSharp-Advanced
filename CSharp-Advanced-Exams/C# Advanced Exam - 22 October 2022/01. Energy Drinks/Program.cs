Stack<int> caffeineMilligrams = new(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Queue<int> energyDrinks = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
int currentAmountOfCaffeine = 0;
int allowedCaffeine = 300;

while (currentAmountOfCaffeine < 300 && caffeineMilligrams.Any() && energyDrinks.Any())
{
    int currentCaffeineMilligrams = caffeineMilligrams.Peek();
    int currentenergyDrink = energyDrinks.Peek();

    if (currentCaffeineMilligrams * currentenergyDrink > allowedCaffeine)
    {
        caffeineMilligrams.Pop();
        energyDrinks.Dequeue();
        energyDrinks.Enqueue(currentenergyDrink);
        currentAmountOfCaffeine -= 30;
        if (currentAmountOfCaffeine < 0)
        {
            currentAmountOfCaffeine = 0;
        }
        allowedCaffeine += 30;
        if (allowedCaffeine > 300)
        {
            allowedCaffeine = 300;
        }
    }
    else
    {
        currentAmountOfCaffeine += currentCaffeineMilligrams * currentenergyDrink;
        allowedCaffeine -= currentCaffeineMilligrams * currentenergyDrink;
        caffeineMilligrams.Pop();
        energyDrinks.Dequeue();
    }
}

if (energyDrinks.Any())
{
    Console.WriteLine($"Drinks left: {string.Join(", ", energyDrinks)}");
}
else
{
    Console.WriteLine($"At least Stamat wasn't exceeding the maximum caffeine.");
}
Console.WriteLine($"Stamat is going to sleep with {currentAmountOfCaffeine} mg caffeine.");
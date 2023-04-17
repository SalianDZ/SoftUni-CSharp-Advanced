Queue<int> cups = new(
    Console.ReadLine()
    .Split().Select(int.Parse)
    );
Stack<int> waterBottles = new(
    Console.ReadLine()
    .Split().Select(int.Parse)
    );
int wastedWater = 0;

while (waterBottles.Count > 0)
{
    if (cups.Count <= 0)
    {
        break;
    }
    int currentBottle = waterBottles.Peek();
    int currentCup = cups.Peek();

    if (currentBottle >= currentCup)
    {
        wastedWater += currentBottle - currentCup;
        cups.Dequeue();
        waterBottles.Pop();
    }
    else if (currentBottle < currentCup)
    {
        int remainder = currentCup - waterBottles.Pop();

        while (remainder > 0)
        {
            if (waterBottles.Peek() >= remainder)
            {
                wastedWater += waterBottles.Pop() - remainder;
                cups.Dequeue();
                remainder = 0;
                continue;
            }

            remainder -= waterBottles.Pop();
        }
    }
}
if (cups.Count > 0)
{
    Console.WriteLine($"Cups: {string.Join(" ", cups)}");
    Console.WriteLine($"Wasted litters of water: {wastedWater}");
}
else
{
    Console.WriteLine($"Bottles: {string.Join(" ", waterBottles)}");
    Console.WriteLine($"Wasted litters of water: {wastedWater}");
}
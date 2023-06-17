Queue<int> tools = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Stack<int> substances = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
List<int> challanges = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
bool hasWon = false;

while (tools.Count > 0 && substances.Count > 0)
{
    int currentTool = tools.Peek();
    int currentSubstance = substances.Peek();
    int sum = currentTool * currentSubstance;

    if (challanges.Any(x => x == sum))
    {
        int wantedChallange = challanges.FirstOrDefault(x => x == sum);
        substances.Pop();
        tools.Dequeue();
        challanges.Remove(wantedChallange);

        if (challanges.Count <= 0)
        {
            hasWon = true;
        }
    }
    else
    {
        currentTool++;
        tools.Dequeue();
        tools.Enqueue(currentTool);

        currentSubstance--;
        substances.Pop();

        if (currentSubstance <= 0)
        {
            continue;
        }
        else
        {
            substances.Push(currentSubstance);
        }
    }
}

if (hasWon)
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
}
else
{
    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
}

if (tools.Count > 0)
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");
}

if (substances.Count > 0)
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
}

if (challanges.Count > 0)
{
    Console.WriteLine($"Challenges: {string.Join(", ", challanges)}");
}
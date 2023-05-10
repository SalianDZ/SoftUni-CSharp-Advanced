HashSet<int> firstSet = new();
HashSet<int> secondSet = new();

int[] counts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();

for (int i = 0; i < counts[0]; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    firstSet.Add(currentNumber);
}

for (int i = 0; i < counts[1]; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    secondSet.Add(currentNumber);
}

firstSet.IntersectWith(secondSet);

Console.WriteLine(String.Join(" ", firstSet));
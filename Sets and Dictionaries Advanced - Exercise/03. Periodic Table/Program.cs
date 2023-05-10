int count = int.Parse(Console.ReadLine());
SortedSet<string> periodicTable = new SortedSet<string>();

for (int i = 0; i < count; i++)
{
    string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

	foreach (var element in elements)
	{
		periodicTable.Add(element);
	}
}

Console.WriteLine(string.Join(" ", periodicTable));

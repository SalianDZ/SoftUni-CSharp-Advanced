int[] startAndEnd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int start = startAndEnd[0];
int end = startAndEnd[1];
List<int> range = Enumerable.Range(start, end - start + 1).ToList();
List<int> result = new List<int>();
string command = Console.ReadLine();

Predicate<int> filter = number => number % 2 == 0;

for (int i = 0; i < range.Count; i++)
{
	if (command == "even")
	{
		if (filter(range[i]))
		{
			result.Add(range[i]);
		}
	}
	else
	{
		if (command == "odd")
		{
            if (!filter(range[i]))
            {
                result.Add(range[i]);
            }
        }
	}
}

Console.WriteLine(string.Join(" ", result));
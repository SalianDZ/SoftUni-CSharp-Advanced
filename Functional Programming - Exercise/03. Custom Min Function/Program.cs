Func<HashSet<int>, int> returnTheSmallestNumber = numbers =>
{
    int minValue = int.MaxValue;

	foreach (var number in numbers)
	{
		if (number < minValue)
		{
			minValue = number;
		}
	}
	return minValue;
};

HashSet<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToHashSet();

Console.WriteLine(returnTheSmallestNumber(numbers));
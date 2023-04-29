double[] input = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
Dictionary<double, int> numbers = new Dictionary<double, int>();

foreach (var number in input)
{
	if (!numbers.ContainsKey(number))
	{
		numbers.Add(number, 0);
	}

	numbers[number]++;
}

foreach (var number in numbers)
{
	Console.WriteLine($"{number.Key} - {number.Value} times");
}
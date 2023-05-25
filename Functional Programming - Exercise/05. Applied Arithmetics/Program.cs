List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
Func<List<int>, List<int>> addFunction = numbers =>
{
	for (int i = 0; i < numbers.Count; i++)
	{
		numbers[i] = numbers[i] + 1;
	}
	return numbers;
};

Func<List<int>, List<int>> subtractFunction = numbers =>
{
    for (int i = 0; i < numbers.Count; i++)
    {
        numbers[i] = numbers[i] - 1;
    }
    return numbers;
};

Func<List<int>, List<int>> multiplyFunction = numbers =>
{
    for (int i = 0; i < numbers.Count; i++)
    {
        numbers[i] = numbers[i] * 2;
    }
    return numbers;
};

Action<List<int>> printNumbers = numbers => Console.WriteLine(string.Join(" ", numbers));

while (true)
{
    string command = Console.ReadLine();

	if (command == "end")
	{
		break;
	}
	else if (command == "add")
	{
		addFunction(numbers); 
	}
	else if (command == "multiply")
	{
		multiplyFunction(numbers);
	}
	else if (command == "subtract")
	{
		subtractFunction(numbers);
	}
	else if (command == "print")
	{
		printNumbers(numbers);
	}

}
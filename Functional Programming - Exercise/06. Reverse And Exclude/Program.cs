List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int divider = int.Parse(Console.ReadLine());

Func<List<int>, Predicate<int>, List<int>> filter = (numbers, match) =>
{
    List<int> result = new();

    foreach (var number in numbers)
    {
        if (!match(number))
        {
            result.Add(number);
        }
    }

    return result;
};

Func<List<int>, List<int>> reverseNumbers = numbers =>
{
    List<int> result = new();


    for (int i = numbers.Count - 1; i >= 0; i--)
    {
        result.Add(numbers[i]);
    }

    return result;
};

numbers = filter(numbers, n => n % divider == 0);
numbers = reverseNumbers(numbers);

Console.WriteLine(String.Join(" ", numbers));
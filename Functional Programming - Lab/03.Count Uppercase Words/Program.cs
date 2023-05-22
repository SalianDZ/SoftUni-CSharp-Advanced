Func<string, bool> filter = GetUppercaseWords;

List<string> text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
	.Select(s => s)
    .Where(GetUppercaseWords).ToList();

bool GetUppercaseWords (string input)
{
	if (char.IsUpper(input[0]))
	{
		return true;
	}
	return false;
}

Console.WriteLine(string.Join(Environment.NewLine, text));
SortedDictionary<char, int> appearances = new();
string text = Console.ReadLine();

foreach (char ch in text)
{
	if (!appearances.ContainsKey(ch))
	{
		appearances[ch] = 0;
	}

	appearances[ch]++;
}

foreach (var appearance in appearances)
{
	Console.WriteLine($"{appearance.Key}: {appearance.Value} time/s");
}
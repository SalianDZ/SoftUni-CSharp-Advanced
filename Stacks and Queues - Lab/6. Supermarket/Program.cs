Queue<string> people = new Queue<string>();
while (true)
{
    string input = Console.ReadLine();

	if (input == "End")
	{
		break;
	}
	else if (input == "Paid")
	{
		Console.WriteLine(String.Join(Environment.NewLine, people));
		people.Clear();
		continue;
	}
	people.Enqueue(input);
}
Console.WriteLine($"{people.Count} people remaining.");
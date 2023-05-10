int count = int.Parse(Console.ReadLine());
Dictionary<int, int> appearances = new Dictionary<int, int>();

for (int i = 0; i < count; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

	if (!appearances.ContainsKey(currentNumber))
	{
		appearances[currentNumber] = 0;
	}

	appearances[currentNumber]++;
}

Console.WriteLine(appearances.Single(x => x.Value % 2 == 0).Key);
int n = int.Parse(Console.ReadLine());
Queue<string> cars = new Queue<string>();
int counter = 0;

while (true)
{
	string input = Console.ReadLine();

	if (input == "end")
	{
		break;
	}
	else if (input == "green")
	{
		for (int i = 0; i < n; i++)
		{
			if (cars.Count > 0)
			{
                Console.WriteLine($"{cars.Dequeue()} passed!");
                counter++;
            }
		}
		continue;
	}

	cars.Enqueue(input);
}
Console.WriteLine($"{counter} cars passed the crossroads.");
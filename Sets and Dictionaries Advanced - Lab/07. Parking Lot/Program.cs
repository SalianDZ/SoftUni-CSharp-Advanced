HashSet<string> parkingLot = new();

while (true)
{
    string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

	if (input[0] == "END")
	{
		break;
	}
	else if (input[0] == "IN")
	{
		string number = input[1];
		parkingLot.Add(number);
	}
	else if (input[0] == "OUT")
	{
        string number = input[1];

		if (parkingLot.Contains(number))
		{
			parkingLot.Remove(number);
		}
    }
}

if (parkingLot.Count > 0)
{
    foreach (var number in parkingLot)
    {
		Console.WriteLine(number);
    }
}
else
{
	Console.WriteLine("Parking Lot is Empty");
}
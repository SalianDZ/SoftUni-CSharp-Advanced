HashSet<string> normalGuests = new();
HashSet<string> vipGuests = new();
HashSet<string> arrivedNormalGuests = new();
HashSet<string> arrivedVipGuests = new();


while (true)
{
    string input = Console.ReadLine();

	if (input == "END")
	{
		break;
	}
	else if (input == "PARTY")
	{
		while (true)
		{
			string currentInput = Console.ReadLine();

			if (currentInput == "END")
			{
                if (vipGuests.Count + normalGuests.Count <= 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(vipGuests.Count + normalGuests.Count);

                    foreach (var vipGuest in vipGuests)
                    {
                        Console.WriteLine(vipGuest);
                    }

                    foreach (var normalGuest in normalGuests)
                    {
                        Console.WriteLine(normalGuest);
                    }
                }
                return;
			}

            if (char.IsDigit(currentInput[0]))
            {
                if (vipGuests.Contains(currentInput))
                {
                    arrivedVipGuests.Add(currentInput);
                    vipGuests.Remove(currentInput);
                }
            }
            else
            {
                if (normalGuests.Contains(currentInput))
                {
                    arrivedNormalGuests.Add(currentInput);
                    normalGuests.Remove(currentInput);
                }
            }
        }
    }

	if (char.IsDigit(input[0]))
	{
		vipGuests.Add(input);
	}
	else
	{
		normalGuests.Add(input);
	}
}

if (vipGuests.Count + normalGuests.Count <= 0)
{
	Console.WriteLine(0);
}
else
{
	Console.WriteLine(vipGuests.Count + normalGuests.Count);

	foreach (var vipGuest in vipGuests)
	{
		Console.WriteLine(vipGuest);
	}

	foreach (var normalGuest in normalGuests)
	{
		Console.WriteLine(normalGuest);
	}
}
using System.Security;

int greenLightDuratrion = int.Parse(Console.ReadLine());
int freeWindowDuration = int.Parse(Console.ReadLine());
Queue<string> cars = new();
int counter = 0;


while (true)
{
    int currentGreenLightDuration = greenLightDuratrion;
    string tokens = Console.ReadLine();

	if (tokens == "END")
	{
		break;
	}
	else if (tokens == "green")
	{
		if (cars.Count <= 0)
		{
			continue;
		}
		while (currentGreenLightDuration > 0)
		{
			if (cars.Count <= 0)
			{
				break;
			}
            string currentCar = cars.Peek();

            if (currentCar.Length <= currentGreenLightDuration)
            {
                cars.Dequeue();
				currentGreenLightDuration -= currentCar.Length;
				counter++;
				continue;
            }
			else
			{
				//This code can cause problems
				int currentCarSeconds = currentCar.Length - currentGreenLightDuration;

				if (currentCarSeconds > freeWindowDuration)
				{
					int characterHit = currentCar.Length - (currentCarSeconds - freeWindowDuration);
					if (characterHit >= currentCar.Length || characterHit < 0)
					{
						continue;
					}
					Console.WriteLine("A crash happened!");
					Console.WriteLine($"{currentCar} was hit at {currentCar[characterHit]}.");
					return;
				}
				else
				{
					counter++;
					cars.Dequeue();
					break;
				}
			}
        }
		continue;
	}

	cars.Enqueue(tokens);
}
Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{counter} total cars passed the crossroads.");
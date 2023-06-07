Stack<int> foodPortions = new(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
Queue<int> stamina = new Queue<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
//Dictionary<int, Dictionary<string, int>> peeks = new Dictionary<int, Dictionary<string, int>>();
//peeks.Add(0, new Dictionary<string, int>());
//peeks[0].Add("Vihren", 80);
//peeks.Add(1, new Dictionary<string, int>());
//peeks[1].Add("Kutelo", 90);
//peeks.Add(2, new Dictionary<string, int>());
//peeks[2].Add("Banski Suhodol", 100);
//peeks.Add(3, new Dictionary<string, int>());
//peeks[3].Add("Polezhan", 60);
//peeks.Add(4, new Dictionary<string, int>());
//peeks[4].Add("Kamenitza", 70);
List<string> peeksList = new() { "Vihren", "Kutelo", "Banski Suhodol", "Polezhan", "Kamenitza" };
Dictionary<string, int> peeks = new();
peeks.Add("Vihren", 80);
peeks.Add("Kutelo", 90);
peeks.Add("Banski Suhodol", 100);
peeks.Add("Polezhan", 60);
peeks.Add("Kamenitza", 70);
List<string> conqueredPeeks = new();

while (foodPortions.Any())
{
    int currentFoodSuply = foodPortions.Peek();
    int currentStaminaSuply = stamina.Peek();

    if (currentFoodSuply + currentStaminaSuply >= peeks[peeksList[0]])
    {
        conqueredPeeks.Add(peeksList[0]);
        peeksList.RemoveAt(0);
        foodPortions.Pop();
        stamina.Dequeue();
        if (peeksList.Count == 0)
        {
            break;
        }
    }
    else
    {
        foodPortions.Pop();
        stamina.Dequeue();
    }
}

if (conqueredPeeks.Count == 5)
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}
else
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}

if (conqueredPeeks.Any())
{
    Console.WriteLine("Conquered peaks:");
    foreach (var conqueredPeek in conqueredPeeks)
    {
        Console.WriteLine(conqueredPeek);
    }
}
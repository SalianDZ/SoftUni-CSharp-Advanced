using System.ComponentModel.Design;

Queue<int> textiles = new(Console.ReadLine().Split().Select(int.Parse));
Stack<int> medicaments = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
Dictionary<string, int> counters = new();
counters.Add("Patch", 0);
counters.Add("Bandage", 0);
counters.Add("MedKit", 0);

while (textiles.Count > 0 || medicaments.Count > 0)
{
    if (textiles.Count <= 0 || medicaments.Count <= 0)
    {
        break;
    }

    int currentTextile = textiles.Peek();
    int currentMedicament = medicaments.Peek();

    if (currentTextile + currentMedicament == 30)
    {
        counters["Patch"]++;
        textiles.Dequeue();
        medicaments.Pop();
    }
    else if (currentTextile + currentMedicament == 40)
    {
        counters["Bandage"]++;
        textiles.Dequeue();
        medicaments.Pop();
    } 
    else if (currentTextile + currentMedicament == 100)
    {
        counters["MedKit"]++;
        textiles.Dequeue();
        medicaments.Pop();
    }
    else if (currentTextile + currentMedicament > 100)
    {
        counters["MedKit"]++;
        int currentSum = (currentMedicament + currentTextile) - 100;
        textiles.Dequeue();

        medicaments.Pop();
        currentMedicament = medicaments.Peek();
        medicaments.Pop();
        medicaments.Push(currentMedicament + currentSum);
    }
    else if (currentMedicament + currentTextile < 100)
    {
        textiles.Dequeue();
        medicaments.Pop();
        medicaments.Push(currentMedicament + 10);
    }
}


if (textiles.Count <= 0 && medicaments.Count <= 0)
{
    Console.WriteLine("Textiles and medicaments are both empty.");
    foreach (var counter in counters.Where(c => c.Value > 0).OrderByDescending(c => c.Value).ThenBy(c => c.Key))
    {
        Console.WriteLine($"{counter.Key} - {counter.Value}");
    }
}
if (textiles.Count <= 0 && medicaments.Count > 0)
{
    Console.WriteLine("Textiles are empty.");
    foreach (var counter in counters.Where(c => c.Value > 0).OrderByDescending(c => c.Value).ThenBy(c => c.Key))
    {
        Console.WriteLine($"{counter.Key} - {counter.Value}");
    }
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}
if (textiles.Count > 0 && medicaments.Count <= 0)
{
    Console.WriteLine("Medicaments are empty.");
    foreach (var counter in counters.Where(c => c.Value > 0).OrderByDescending(c => c.Value).ThenBy(c => c.Key))
    {
        Console.WriteLine($"{counter.Key} - {counter.Value}");
    }
    Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
}
Dictionary<string, Dictionary<string, int>> wardrobe = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(new string[] {" -> ", ","}, StringSplitOptions.RemoveEmptyEntries);

    if (!wardrobe.ContainsKey(tokens[0]))
    {
        wardrobe[tokens[0]] = new Dictionary<string, int>();
    }

    for (int j = 1; j < tokens.Length; j++)
    {

        if (!wardrobe[tokens[0]].ContainsKey(tokens[j]))
        {
            wardrobe[tokens[0]].Add(tokens[j], 0); ;
        }

        wardrobe[tokens[0]][tokens[j]]++;
    }
}

string[] searchedItem = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string color = searchedItem[0];
string clothing = searchedItem[1];


foreach (var currentClothing in wardrobe)
{
    Console.WriteLine($"{currentClothing.Key} clothes:");
    foreach (var cloth in currentClothing.Value)
    {
        if (color == currentClothing.Key && clothing == cloth.Key)
        {
            Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
        }
    }
}

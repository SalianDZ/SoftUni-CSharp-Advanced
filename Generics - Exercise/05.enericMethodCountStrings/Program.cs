using GenericMethodCountStrings;

Box<string> box = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string item = Console.ReadLine();

    box.Add(item);
}

string elementToCompare = Console.ReadLine();
Console.WriteLine(box.CompareTo(elementToCompare));
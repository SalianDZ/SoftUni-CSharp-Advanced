using GenericMethodCountDoubles;

Box<double> box = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    double item = double.Parse(Console.ReadLine());

    box.Add(item);
}

double elementToCompare = double.Parse(Console.ReadLine());
Console.WriteLine(box.CompareTo(elementToCompare));
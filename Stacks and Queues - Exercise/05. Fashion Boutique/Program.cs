using System.Security;
int[] box = Console.ReadLine()
    .Split().Select(int.Parse).ToArray();
int capacity = int.Parse(Console.ReadLine());
int currentCapacity = capacity;
Stack<int> clothes = new(box);
int containerCounter = 1;

while (clothes.Count > 0)
{
	currentCapacity -= clothes.Peek();

	if (currentCapacity < 0)
	{
		currentCapacity = capacity;
		containerCounter++;
		continue;
	}
    clothes.Pop();
}
Console.WriteLine(containerCounter);
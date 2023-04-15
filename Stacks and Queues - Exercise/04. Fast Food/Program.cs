int quantity = int.Parse(Console.ReadLine());
int[] numbers = Console.ReadLine()
    .Split().Select(int.Parse).ToArray();
Queue<int> queue = new(numbers);

Console.WriteLine(queue.Max());
while (queue.Count != 0)
{
	if (quantity - queue.Peek() < 0)
	{
		break;
	}
	quantity -= queue.Peek();
	queue.Dequeue();	
}

if (queue.Count > 0)
{
	Console.WriteLine($"Orders left: {String.Join(" ", queue)}");
}
else
{
	Console.WriteLine("Orders complete");
}
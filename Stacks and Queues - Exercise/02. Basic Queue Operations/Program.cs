int[] tokens = Console.ReadLine()
    .Split().Select(int.Parse).ToArray();

int[] numbers = Console.ReadLine()
    .Split().Select(int.Parse).ToArray();

int numbersToDequeue = tokens[1];
int number = tokens[2];

Queue<int> ints = new(numbers);


for (int i = 0; i < numbersToDequeue; i++)
{
    ints.Dequeue();
}

if (ints.Contains(number))
{
    Console.WriteLine("true");
}
else
{
    if (ints.Any())
    {
        Console.WriteLine(ints.Min());
    }
    else
    {
        Console.WriteLine(0);
    }
}
int[] tokens = Console.ReadLine()
    .Split().Select(int.Parse).ToArray();

int[] numbers = Console.ReadLine()
    .Split().Select(int.Parse).ToArray();

int numbersToPush = tokens[0];
int numbersToPop = tokens[1];
int number = tokens[2];

Stack<int> ints = new Stack<int>();
for (int i = 0; i < numbersToPush; i++)
{
    ints.Push(numbers[i]);
}

for (int i = 0; i < numbersToPop; i++)
{
    ints.Pop();
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
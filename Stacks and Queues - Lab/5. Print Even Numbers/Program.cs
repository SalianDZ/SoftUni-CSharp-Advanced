int[] inputNumbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
Queue<int> numbers =new Queue<int>(inputNumbers);
int count = numbers.Count;

for (int i = 0; i < count; i++)
{
    int currentNumber = numbers.Dequeue();

    if (currentNumber % 2 == 0)
    {
        numbers.Enqueue(currentNumber);
    }
}
Console.WriteLine(String.Join(", ", numbers));
int count = int.Parse(Console.ReadLine());
Stack<int> numbers = new();
for (int i = 0; i < count; i++)
{
    int[] command = Console.ReadLine()
        .Split().Select(int.Parse).ToArray();

    if (command[0] == 1)
    {
        numbers.Push(command[1]);
    }
    else if (command[0] == 2)
    {
        if (numbers.Any())
        {
            numbers.Pop();
        }
    }
    else if (command[0] == 3)
    {
        if (numbers.Any())
        {
            Console.WriteLine(numbers.Max());
        }
    }
    else if (command[0] == 4)
    {
        if (numbers.Any())
        {
            Console.WriteLine(numbers.Min());
        }
    }
}
Console.WriteLine(String.Join(", ", numbers));
int[] numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();
Stack<int> stack = new Stack<int>(numbers);

while (true)
{
    string[] command = Console.ReadLine().Split();
    string currentCommand = command[0].ToLower();

    if (currentCommand == "end")
    {
        break;
    }
    else if (currentCommand == "add")
    {
        int firstNumber = int.Parse(command[1]);
        int secondNumber = int.Parse(command[2]);
        stack.Push(firstNumber); 
        stack.Push(secondNumber);
    }
    else if (currentCommand == "remove")
    {
        int count = int.Parse(command[1]);

        if (count <= stack.Count)
        {
            for (int i = 0; i < count; i++)
            {
                stack.Pop();
            }
        }
    }
}
Console.WriteLine($"Sum: {stack.Sum()}");

int commandsCount = int.Parse(Console.ReadLine());
Stack<string> changes = new();
string text = string.Empty;


for (int i = 0; i < commandsCount; i++)
{
    string[] tokens = Console.ReadLine()
        .Split();

    int command = int.Parse(tokens[0]);

    switch (command)
    {
        case 1:
            changes.Push(text);
            string substring = tokens[1];
            text += substring;
            break;
        case 2:
            changes.Push(text);
            int count = int.Parse(tokens[1]);
            text = text.Remove(text.Length - count);
            break;
        case 3:
            int index = int.Parse(tokens[1]);
            Console.WriteLine(text[index - 1]);
            break;
        case 4:
            text = changes.Pop();
            break;
    }
}
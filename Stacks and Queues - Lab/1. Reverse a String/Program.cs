string text = Console.ReadLine();
Stack<char> stack = new Stack<char>();

foreach (char ch in text)
{
    stack.Push(ch);
}

while (stack.Count > 0)
{
    Console.Write(stack.Pop());
}
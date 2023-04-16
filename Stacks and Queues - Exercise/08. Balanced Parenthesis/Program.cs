string input = Console.ReadLine();
Stack<char> stack = new Stack<char>(input);
int begginingCount = stack.Count;
Stack<char> reversedStack = new Stack<char>(stack);
bool isSame = true;

if (input.Length % 2 != 0)
{
	Console.WriteLine("NO");
	return;
}

while (stack.Count > 0 && reversedStack.Count > 0)
{
    if (stack.Count <= begginingCount || reversedStack.Count <= begginingCount)
    {
        break;
    }
	if (reversedStack.Peek() == '{')
	{
		if (stack.Peek() == '}')
		{
			stack.Pop();
			reversedStack.Pop();
			continue;
		}
		isSame = false;
		break;
	}
	else if (reversedStack.Peek() == '[')
	{
        if (stack.Peek() == ']')
        {
            stack.Pop();
            reversedStack.Pop();
            continue;
        }
        isSame = false;
        break;
    }
	else if (reversedStack.Peek() == '(')
	{
        if (stack.Peek() == ')')
        {
            stack.Pop();
            reversedStack.Pop();
            continue;
        }
        isSame = false;
        break;
    }
    else
    {
        isSame = false;
        break;
    }
}
if (isSame)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

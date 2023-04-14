string expression = Console.ReadLine();
Stack<int> stack = new Stack<int>();

for (int i = 0; i < expression.Length; i++)
{
	if (expression[i] == '(')
	{
		stack.Push(i);
	}
	else if (expression[i] == ')')
	{
		int startIndex = stack.Pop();
		int endIndex = i;
		string substring = expression.Substring(startIndex, endIndex - startIndex + 1);
		Console.WriteLine(substring);
    }
}
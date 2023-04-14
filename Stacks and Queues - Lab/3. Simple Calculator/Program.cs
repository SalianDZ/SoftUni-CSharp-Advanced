string[] expression = Console.ReadLine().Split().Reverse().ToArray();
Stack<string> stack = new Stack<string>(expression);

while (stack.Count > 1)
{
    int firstNumber = int.Parse(stack.Pop());
    string symbol = stack.Pop();
    int secondNumber = int.Parse(stack.Pop());

    if (symbol == "+")
    {
        int sum = firstNumber + secondNumber;
        stack.Push(sum.ToString());
    }
    else
    {
        int sum = firstNumber - secondNumber;
        stack.Push(sum.ToString());
    }
}
Console.WriteLine(String.Join("", stack));
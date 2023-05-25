Action<string[]> printStrings = strings => Console.WriteLine(string.Join(Environment.NewLine, strings));
string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
printStrings(strings);
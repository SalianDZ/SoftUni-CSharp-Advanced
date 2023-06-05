using Tuple;

string[] personTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] drinkTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] numberTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

CustomTuple<string, string> personTuple= new($"{personTokens[0]} {personTokens[1]}", personTokens[2]);

CustomTuple<string, int> drinkTuple = new(drinkTokens[0], int.Parse(drinkTokens[1]));

CustomTuple<int, double> numberTuple = new(int.Parse(numberTokens[0]), double.Parse(numberTokens[1]));

Console.WriteLine(personTuple);
Console.WriteLine(drinkTuple);
Console.WriteLine(numberTuple);
using Threeuple;

string[] personTokens = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] drinkTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

string[] bankTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

CustomThreeuple<string, string, string> personThreeuple = new($"{personTokens[0]} {personTokens[1]}", personTokens[2], string.Join(" ", personTokens[3..]));

CustomThreeuple<string, int, bool> drinkThreeuple = new(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");

CustomThreeuple<string, double, string> numberThreeuple = new(bankTokens[0], double.Parse(bankTokens[1]), bankTokens[2]);

Console.WriteLine(personThreeuple);
Console.WriteLine(drinkThreeuple);
Console.WriteLine(numberThreeuple);
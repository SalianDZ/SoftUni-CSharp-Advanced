Action<string[]> printStrings = strings => {
     foreach (var currentString in strings)
     {
         Console.WriteLine($"Sir {currentString}");
     }
 };
string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
printStrings(strings);
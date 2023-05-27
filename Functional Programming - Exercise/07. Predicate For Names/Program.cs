int length = int.Parse(Console.ReadLine());
List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

Predicate<string> match = name => name.Length <= length;
Func<List<string>, Predicate<string>, List<string>> filterNames = (names, match) =>
{
    List<string> result = new();

    foreach (var name in names)
    {
        if (match(name))
        {
            result.Add(name);
        }
    }

    return result;
};

names = filterNames(names, match);

Action<List<string>> printNames = names => Console.WriteLine(string.Join(Environment.NewLine, names));
printNames(names);

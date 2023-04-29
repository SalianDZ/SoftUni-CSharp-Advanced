List<int> numbers = new(Console.ReadLine().Split().Select(int.Parse).ToList());
numbers = numbers.OrderByDescending(x => x).Take(3).ToList();
Console.WriteLine(String.Join(" ", numbers));
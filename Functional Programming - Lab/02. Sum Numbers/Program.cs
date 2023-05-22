int[] numbers = Console.ReadLine().Split(", ").Select(Parse).ToArray();
Console.WriteLine(numbers.Length);
Console.WriteLine(numbers.Sum());

int Parse(string x)
{
    int convertedInt = int.Parse(x);
    return convertedInt;
}
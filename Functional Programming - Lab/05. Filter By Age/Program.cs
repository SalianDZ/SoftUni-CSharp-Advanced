int n = int.Parse(Console.ReadLine());
List<Person> people = new();

for (int i = 0; i < n; i++)
{
            string[] tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string currentName = tokens[0];
            int currentAge = int.Parse(tokens[1]);

            Person person = new Person(currentName, currentAge);
            people.Add(person);
}

string condition = Console.ReadLine();
int ageThreshold = int.Parse(Console.ReadLine());
string formatType = Console.ReadLine();

Func<Person,int, bool> filter = CreateFilter(condition);

people = people.Where(p => filter(p, ageThreshold)).ToList();

Action<Person> formatter = GetFormatter(formatType);

foreach (var person in people)
 {
            formatter(person);
 }

Func<Person, int, bool> CreateFilter(string condition)
{
    if (condition == "younger")
    {
        return (p, value) => p.Age < value;
    }
    else if (condition == "older")
    {
        return (Person p, int value) => p.Age >= value;
    }
    return null;
}


Action<Person> GetFormatter(string formatType)
    {
        if (formatType == "name age")
        {
            return p => Console.WriteLine($"{p.Name} - {p.Age}");
        }
        if (formatType == "name")
        {
            return p => Console.WriteLine($"{p.Name}");
        }
        if (formatType == "age")
        {
            return p => Console.WriteLine($"{p.Age}");
        }
        return null;
    }


public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }

    public int Age { get; set; }
}
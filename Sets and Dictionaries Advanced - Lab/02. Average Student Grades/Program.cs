using System.Text;

int count = int.Parse(Console.ReadLine());
Dictionary<string, List<decimal>> studentsGrades = new();

for (int i = 0; i < count; i++)
{
    string[] input = Console.ReadLine().Split();
    decimal currentGrade = decimal.Parse(input[1]);

    if (!studentsGrades.ContainsKey(input[0]))
    {
        studentsGrades.Add(input[0], new List<decimal>());
    }
    studentsGrades[input[0]].Add(currentGrade);
}

foreach (var student in studentsGrades)
{
    StringBuilder sb = new();
    sb.Append($"{student.Key} -> ");
    foreach (var grade in student.Value)
    {
        sb.Append($"{grade:f2} ");
    }
    sb.Append($"(avg: {student.Value.Average():f2})");
    Console.WriteLine(sb.ToString());
}
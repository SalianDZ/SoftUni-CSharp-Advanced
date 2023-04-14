string[] names = Console.ReadLine()
    .Split();
Queue<string> people = new Queue<string>(names);
int n = int.Parse(Console.ReadLine());
int tosses = 1;
int counter = 0;

while (people.Count != 0)
{
    if (tosses < n)
    {
        string currentPerson = people.Dequeue();
        tosses++;
        people.Enqueue(currentPerson);
        counter++;
    }
    else
    {
        tosses = 1;
        if (people.Count == 1)
        {
            Console.WriteLine($"Last is {people.Dequeue()}");
            break;
        }
        else
        {
            Console.WriteLine($"Removed {people.Dequeue()}");
        }
    }
}

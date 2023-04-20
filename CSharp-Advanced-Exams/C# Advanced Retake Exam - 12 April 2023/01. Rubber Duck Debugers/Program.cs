Queue<int> programmerTime = new(Console.ReadLine()
        .Split().Select(int.Parse)
    );
Stack<int> tasksNumber = new(Console.ReadLine()
    .Split().Select(int.Parse)
    );
int darthVaderDuckyCounter = 0;
int thorDuckyCounter = 0;
int bigBlueRubberCounter = 0;
int smallYellowRubberDucky = 0;

while (programmerTime.Any())
{
    int currentProgrammerTime = programmerTime.Peek();
    int currentTaskNumber = tasksNumber.Peek();
    int result = currentProgrammerTime * currentTaskNumber;

    if (result >= 0 && result <= 240)
    {
        if (result >= 0 && result <= 60)
        {
            darthVaderDuckyCounter++;
        }
        else if (result >= 61 && result <= 120)
        {
            thorDuckyCounter++;
        }
        else if (result >= 121 && result <= 180)
        {
            bigBlueRubberCounter++;
        }
        else if (result >= 181 && result <= 240)
        {
            smallYellowRubberDucky++;
        }
        programmerTime.Dequeue();
        tasksNumber.Pop();
        continue;
    }

    programmerTime.Dequeue();
    programmerTime.Enqueue(currentProgrammerTime);
    tasksNumber.Pop();
    tasksNumber.Push(currentTaskNumber - 2);
}
Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
Console.WriteLine($"Darth Vader Ducky: {darthVaderDuckyCounter}");
Console.WriteLine($"Thor Ducky: {thorDuckyCounter}");
Console.WriteLine($"Big Blue Rubber Ducky: {bigBlueRubberCounter}");
Console.WriteLine($"Small Yellow Rubber Ducky: {smallYellowRubberDucky}");
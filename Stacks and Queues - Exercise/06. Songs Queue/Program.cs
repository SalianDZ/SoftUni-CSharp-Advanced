using System.Security;

string[] input = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
Queue<string> songs = new(input);

while (songs.Count != 0)
{
    string currentCommand = Console.ReadLine();
    string[] command = currentCommand.Split(" ");
    

    if (command[0] == "Play")
    {
        if (songs.Count <= 0)
        {
            continue;
        }
        songs.Dequeue();
    }
    else if (command[0] == "Add")
    {
        string currentSong = string.Empty;

        for (int i = 4; i < currentCommand.Length; i++)
        {
            currentSong += currentCommand[i];
        }

        if (songs.Contains(currentSong))
        {
            Console.WriteLine($"{currentSong} is already contained!");
            continue;
        }
        songs.Enqueue(currentSong);
    }
    else if (command[0] == "Show")
    {
        Console.WriteLine(String.Join(", ", songs));
    }
}

Console.WriteLine("No more songs!");
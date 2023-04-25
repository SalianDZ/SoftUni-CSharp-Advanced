int rows = int.Parse(Console.ReadLine());
int[][] jaggedArray = new int[rows][];

for (int row = 0; row < rows; row++)
{
    jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}

for (int row = 0; row < rows; row++)
{
	if (row + 1 >= jaggedArray.Length)
	{
		break;
	}

	if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
	{
		for (int col = 0; col < jaggedArray[row].Length; col++)
		{
			jaggedArray[row][col] *= 2;
        }
        for (int col = 0; col < jaggedArray[row + 1].Length; col++)
        {
            jaggedArray[row + 1][col] *= 2;
        }
    }
    else
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
        {
            jaggedArray[row][col] /= 2;
        }
        for (int col = 0; col < jaggedArray[row + 1].Length; col++)
        {
            jaggedArray[row + 1][col] /= 2;
        }
    }
}

while (true)
{
    string[] command = Console.ReadLine().Split();

    if (command[0] == "End")
    {
        break;
    }
    else if (command[0] == "Add")
    {
        int row = int.Parse(command[1]);
        int col = int.Parse(command[2]);
        int value =int.Parse(command[3]);

        if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
        {
            jaggedArray[row][col] += value;
        }
    }
    else if (command[0] == "Subtract")
    {
        int row = int.Parse(command[1]);
        int col = int.Parse(command[2]);
        int value = int.Parse(command[3]);

        if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
        {
            jaggedArray[row][col] -= value;
        }
    }
}

for (int row = 0; row < jaggedArray.Length; row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write(jaggedArray[row][col] + " ");
    }
    Console.WriteLine();
}
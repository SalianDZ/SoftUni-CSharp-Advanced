int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
    int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = data[col];
    }
}

string[] bombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (var item in bombs)
{
    int[] currentBombData = item.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray();
    int currentBombRow = currentBombData[0];
    int currentBombCol = currentBombData[1];
    Explode(currentBombRow, currentBombCol);
}

int sum = 0;
int counter = 0;
for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        if (matrix[row, col] > 0)
        {
            sum += matrix[row, col];
            counter++;
        }
    }
}

Console.WriteLine($"Alive cells: {counter}");
Console.WriteLine($"Sum: {sum}");
for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}


void Explode(int row, int col)
{
    int value = matrix[row, col];
    matrix[row, col] = 0;
    //Upper Part
    if (row - 1 >= 0 && col - 1 >= 0)
    {
        if (matrix[row - 1, col - 1] > 0)
        {
            matrix[row - 1, col - 1] -= value;
        }
    }

    if (row - 1 >= 0)
    {
        if (matrix[row - 1, col] > 0)
        {
            matrix[row - 1, col] -= value;
        }
    }

    if (row - 1 >= 0 && col + 1 < size)
    {
        if (matrix[row - 1, col + 1] > 0)
        {
            matrix[row - 1, col + 1] -= value;
        }
    }

    //Right Part

    if (col + 1 < size)
    {
        if (matrix[row, col + 1] > 0)
        {
            matrix[row, col + 1] -= value;
        }
    }



    //Lower Part
    if (row + 1 < size && col + 1 < size)
    {
        if (matrix[row + 1, col + 1] > 0)
        {
            matrix[row + 1, col + 1] -= value;
        }
    }

    if (row + 1 < size)
    {
        if (matrix[row + 1, col] > 0)
        {
            matrix[row + 1, col] -= value;
        }
    }

    if (row + 1 < size && col - 1 >= 0)
    {
        if (matrix[row + 1, col - 1] > 0)
        {
            matrix[row + 1, col - 1] -= value;
        }
    }

    //Left Part

    if (col - 1 >= 0)
    {
        if (matrix[row, col - 1] > 0)
        {
            matrix[row, col - 1] -= value;
        }
    }
}
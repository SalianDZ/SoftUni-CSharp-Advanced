int size = int.Parse(Console.ReadLine());
char[,] map = new char[size, size];
int submarinePositionRow = 0;
int submarinePositionCol = 0;


for (int row = 0; row < size; row++)
{
    string data = Console.ReadLine();

    for (int col = 0; col < size; col++)
    {
        map[row, col] = data[col];

        if (map[row, col] == 'S')
        {
            submarinePositionRow = row;
            submarinePositionCol = col;
        }
    }
}
int blownedMines = 0;
int destroyedBattleCruisers = 0;

while (true)
{
    string command = Console.ReadLine();

    if (command == "up")
    {
        if (IndexChecker(submarinePositionRow, submarinePositionCol)
            && IndexChecker(submarinePositionRow - 1, submarinePositionCol))
        {
            if (map[submarinePositionRow - 1, submarinePositionCol] == '-')
            {
                map[submarinePositionRow, submarinePositionCol] = '-';
                submarinePositionRow--;
                map[submarinePositionRow, submarinePositionCol] = 'S';
            }
            else if (map[submarinePositionRow - 1, submarinePositionCol] == '*')
            {
                map[submarinePositionRow, submarinePositionCol] = '-';
                submarinePositionRow--;
                map[submarinePositionRow, submarinePositionCol] = 'S';
                blownedMines++;
                if (blownedMines == 3)
                {
                    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarinePositionRow}, {submarinePositionCol}]!");
                    for (int row = 0; row < map.GetLength(0); row++)
                    {
                        for (int col = 0; col < map.GetLength(1); col++)
                        {
                            Console.Write(map[row, col]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }
            }
            else if(map[submarinePositionRow - 1, submarinePositionCol] == 'C')
            {
                map[submarinePositionRow, submarinePositionCol] = '-';
                submarinePositionRow--;
                map[submarinePositionRow, submarinePositionCol] = 'S';
                destroyedBattleCruisers++;
                if (destroyedBattleCruisers == 3)
                {
                    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                    for (int row = 0; row < map.GetLength(0); row++)
                    {
                        for (int col = 0; col < map.GetLength(1); col++)
                        {
                            Console.Write(map[row, col]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }
            }
        }
    }
    else if (command == "right")
    {

        if (IndexChecker(submarinePositionRow, submarinePositionCol)
            && IndexChecker(submarinePositionRow, submarinePositionCol + 1))
        {
            if (map[submarinePositionRow, submarinePositionCol + 1] == '-')
            {
                map[submarinePositionRow, submarinePositionCol] = '-';
                submarinePositionCol++;
                map[submarinePositionRow, submarinePositionCol] = 'S';
            }
            else if (map[submarinePositionRow, submarinePositionCol + 1] == '*')
            {
                map[submarinePositionRow, submarinePositionCol] = '-';
                submarinePositionCol++;
                map[submarinePositionRow, submarinePositionCol] = 'S';
                blownedMines++;
                if (blownedMines == 3)
                {
                    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarinePositionRow}, {submarinePositionCol}]!");
                    for (int row = 0; row < map.GetLength(0); row++)
                    {
                        for (int col = 0; col < map.GetLength(1); col++)
                        {
                            Console.Write(map[row, col]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }
            }
            else if (map[submarinePositionRow, submarinePositionCol + 1] == 'C')
            {
                map[submarinePositionRow, submarinePositionCol] = '-';
                submarinePositionCol++;
                map[submarinePositionRow, submarinePositionCol] = 'S';
                destroyedBattleCruisers++;
                if (destroyedBattleCruisers == 3)
                {
                    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                    for (int row = 0; row < map.GetLength(0); row++)
                    {
                        for (int col = 0; col < map.GetLength(1); col++)
                        {
                            Console.Write(map[row, col]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }
            }
        }
    }
    else if (command == "down")
    {
        if (IndexChecker(submarinePositionRow, submarinePositionCol)
            && IndexChecker(submarinePositionRow + 1, submarinePositionCol))
        {
            if (map[submarinePositionRow + 1, submarinePositionCol] == '-')
            {
                map[submarinePositionRow, submarinePositionCol] = '-';
                submarinePositionRow++;
                map[submarinePositionRow, submarinePositionCol] = 'S';
            }
            else if (map[submarinePositionRow + 1, submarinePositionCol] == '*')
            {
                map[submarinePositionRow, submarinePositionCol] = '-';
                submarinePositionRow++;
                map[submarinePositionRow, submarinePositionCol] = 'S';
                blownedMines++;
                if (blownedMines == 3)
                {
                    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarinePositionRow}, {submarinePositionCol}]!");
                    for (int row = 0; row < map.GetLength(0); row++)
                    {
                        for (int col = 0; col < map.GetLength(1); col++)
                        {
                            Console.Write(map[row, col]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }
            }
            else if (map[submarinePositionRow + 1, submarinePositionCol] == 'C')
            {
                map[submarinePositionRow, submarinePositionCol] = '-';
                submarinePositionRow++;
                map[submarinePositionRow, submarinePositionCol] = 'S';
                destroyedBattleCruisers++;
                if (destroyedBattleCruisers == 3)
                {
                    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                    for (int row = 0; row < map.GetLength(0); row++)
                    {
                        for (int col = 0; col < map.GetLength(1); col++)
                        {
                            Console.Write(map[row, col]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }
            }
        }
    }
    else if (command == "left")
    {
        if (IndexChecker(submarinePositionRow, submarinePositionCol)
            && IndexChecker(submarinePositionRow, submarinePositionCol - 1))
        {
            if (map[submarinePositionRow, submarinePositionCol - 1] == '-')
            {
                map[submarinePositionRow, submarinePositionCol] = '-';
                submarinePositionCol--;
                map[submarinePositionRow, submarinePositionCol] = 'S';
            }
            else if (map[submarinePositionRow, submarinePositionCol - 1] == '*')
            {
                map[submarinePositionRow, submarinePositionCol] = '-';
                submarinePositionCol--;
                map[submarinePositionRow, submarinePositionCol] = 'S';
                blownedMines++;
                if (blownedMines == 3)
                {
                    Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{submarinePositionRow}, {submarinePositionCol}]!");
                    for (int row = 0; row < map.GetLength(0); row++)
                    {
                        for (int col = 0; col < map.GetLength(1); col++)
                        {
                            Console.Write(map[row, col]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }
            }
            else if (map[submarinePositionRow, submarinePositionCol - 1] == 'C')
            {
                map[submarinePositionRow, submarinePositionCol] = '-';
                submarinePositionCol--;
                map[submarinePositionRow, submarinePositionCol] = 'S';
                destroyedBattleCruisers++;
                if (destroyedBattleCruisers == 3)
                {
                    Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                    for (int row = 0; row < map.GetLength(0); row++)
                    {
                        for (int col = 0; col < map.GetLength(1); col++)
                        {
                            Console.Write(map[row, col]);
                        }
                        Console.WriteLine();
                    }
                    return;
                }
            }
        }
    }
}

bool IndexChecker(int rowIndex, int colIndex)
{
    if (rowIndex >= 0 && rowIndex < map.GetLength(0)
        && colIndex >= 0 && colIndex < map.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
    }
}
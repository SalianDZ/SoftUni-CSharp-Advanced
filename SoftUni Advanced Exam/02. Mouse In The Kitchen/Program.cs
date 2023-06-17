int[] position = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = position[0];
int cols = position[1];

char[,] map = new char[rows, cols];

int mouseRow = 0;
int mouseCol = 0;
int cheeseCounter = 0;
int currentCheese = 0;

for (int row = 0; row < rows; row++)
{
    string data = Console.ReadLine();

    for (int col = 0; col < cols; col++)
    {
        map[row, col] = data[col];

        if (map[row, col] == 'M')
        {
            mouseRow = row;
            mouseCol = col;
        }

        if (map[row, col] == 'C')
        {
            cheeseCounter++;
        }
    }
}

while (true)
{
    string command = Console.ReadLine();
    if (command == "danger")
    {
        Console.WriteLine("Mouse will come back later!");
        break;
    }
    else if (command == "up")
    {
        if (IndexChecker(mouseRow, mouseCol)
            && IndexChecker(mouseRow - 1, mouseCol))
        {
            if (map[mouseRow - 1, mouseCol] == '*')
            {
                map[mouseRow, mouseCol] = '*';
                mouseRow--;
                map[mouseRow, mouseCol] = 'M';
            }
            else if (map[mouseRow - 1, mouseCol] == 'C')
            {
                map[mouseRow, mouseCol] = '*';
                mouseRow--;
                map[mouseRow, mouseCol] = 'M';
                currentCheese++;

                if (currentCheese >= cheeseCounter)
                {
                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    break;
                }
            }
            else if (map[mouseRow - 1, mouseCol] == 'T')
            {
                map[mouseRow, mouseCol] = '*';
                mouseRow--;
                map[mouseRow, mouseCol] = 'M';
                Console.WriteLine("Mouse is trapped!");
                break;
            }
        }
        else
        {
            Console.WriteLine("No more cheese for tonight!");
            break;
        }
    }
    else if (command == "right")
    {
        if (IndexChecker(mouseRow, mouseCol)
            && IndexChecker(mouseRow, mouseCol + 1))
        {
            if (map[mouseRow, mouseCol + 1] == '*')
            {
                map[mouseRow, mouseCol] = '*';
                mouseCol++;
                map[mouseRow, mouseCol] = 'M';
            }
            else if (map[mouseRow, mouseCol + 1] == 'C')
            {
                map[mouseRow, mouseCol] = '*';
                mouseCol++;
                map[mouseRow, mouseCol] = 'M';
                currentCheese++;

                if (currentCheese >= cheeseCounter)
                {
                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    break;
                }
            }
            else if (map[mouseRow, mouseCol + 1] == 'T')
            {
                map[mouseRow, mouseCol] = '*';
                mouseCol++;
                map[mouseRow, mouseCol] = 'M';
                Console.WriteLine("Mouse is trapped!");
                break;
            }
        }
        else
        {
            Console.WriteLine("No more cheese for tonight!");
            break;
        }
    }
    else if (command == "down")
    {
        if (IndexChecker(mouseRow, mouseCol)
            && IndexChecker(mouseRow + 1, mouseCol))
        {
            if (map[mouseRow + 1, mouseCol] == '*')
            {
                map[mouseRow, mouseCol] = '*';
                mouseRow++;
                map[mouseRow, mouseCol] = 'M';
            }
            else if (map[mouseRow + 1, mouseCol] == 'C')
            {
                map[mouseRow, mouseCol] = '*';
                mouseRow++;
                map[mouseRow, mouseCol] = 'M';
                currentCheese++;

                if (currentCheese >= cheeseCounter)
                {
                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    break;
                }
            }
            else if (map[mouseRow + 1, mouseCol] == 'T')
            {
                map[mouseRow, mouseCol] = '*';
                mouseRow++;
                map[mouseRow, mouseCol] = 'M';
                Console.WriteLine("Mouse is trapped!");
                break;
            }
        }
        else
        {
            Console.WriteLine("No more cheese for tonight!");
            break;
        }
    }
    else if (command == "left")
    {
        if (IndexChecker(mouseRow, mouseCol)
            && IndexChecker(mouseRow, mouseCol - 1))
        {
            if (map[mouseRow, mouseCol - 1] == '*')
            {
                map[mouseRow, mouseCol] = '*';
                mouseCol--;
                map[mouseRow, mouseCol] = 'M';
            }
            else if (map[mouseRow, mouseCol - 1] == 'C')
            {
                map[mouseRow, mouseCol] = '*';
                mouseCol--;
                map[mouseRow, mouseCol] = 'M';
                currentCheese++;

                if (currentCheese >= cheeseCounter)
                {
                    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                    break;
                }
            }
            else if (map[mouseRow, mouseCol - 1] == 'T')
            {
                map[mouseRow, mouseCol] = '*';
                mouseCol--;
                map[mouseRow, mouseCol] = 'M';
                Console.WriteLine("Mouse is trapped!");
                break;
            }
        }
        else
        {
            Console.WriteLine("No more cheese for tonight!");
            break;
        }
    }
}

for (int row = 0; row < map.GetLength(0); row++)
{
    for (int col = 0; col < map.GetLength(1); col++)
    {
        Console.Write(map[row, col]);
    }
    Console.WriteLine();
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
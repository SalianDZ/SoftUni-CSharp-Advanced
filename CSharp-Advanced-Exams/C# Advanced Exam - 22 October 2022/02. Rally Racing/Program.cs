int size = int.Parse(Console.ReadLine());
string carName = Console.ReadLine();
char[,] map = new char[size, size];
int carPositionRow = 0;
int carPositionCol = 0;
string tunnelCordinates = string.Empty;

for (int row = 0; row < size; row++)
{
    string data = Console.ReadLine();
    data = data.Replace(" ", "");


    for (int col = 0; col < size; col++)
    {
        map[row, col] = data[col];

        if (map[row, col] == 'T')
        {
            tunnelCordinates += row.ToString();
            tunnelCordinates += col.ToString();
        }
    }
}

int firstTunnelRow = int.Parse(tunnelCordinates[0].ToString());
int firstTunnelCol = int.Parse(tunnelCordinates[1].ToString());
int secondTunnelRow = int.Parse(tunnelCordinates[2].ToString());
int secondTunnelCol = int.Parse(tunnelCordinates[3].ToString());

map[0, 0] = 'C';
int kilometersCounter = 0;
while (true)
{
    string command = Console.ReadLine();

    if (command == "End")
    {
        Console.WriteLine($"Racing car {carName} DNF.");
        break;
    }
    else if (command == "up")
    {
        if (IndexChecker(carPositionRow, carPositionCol)
            && IndexChecker(carPositionRow - 1, carPositionCol))
        {
            if (map[carPositionRow - 1, carPositionCol] == '.')
            {
                kilometersCounter += 10;
                map[carPositionRow, carPositionCol] = '.';
                carPositionRow--;
                map[carPositionRow, carPositionCol] = 'C';
            }
            else if (map[carPositionRow - 1, carPositionCol] == 'T')
            {
                kilometersCounter += 30;
                map[carPositionRow, carPositionCol] = '.';
                carPositionRow--;
                if (carPositionRow == firstTunnelRow && carPositionCol == firstTunnelCol)
                {
                    map[carPositionRow, carPositionCol] = '.';
                    carPositionRow = secondTunnelRow;
                    carPositionCol = secondTunnelCol;
                    map[carPositionRow, carPositionCol] = 'C';
                }
                else if (carPositionRow == secondTunnelRow && carPositionCol == secondTunnelCol)
                {
                    map[carPositionRow, carPositionCol] = '.';
                    carPositionRow = firstTunnelRow;
                    carPositionCol = firstTunnelCol;
                    map[carPositionRow, carPositionCol] = 'C';
                }
            }
            else if(map[carPositionRow - 1, carPositionCol] == 'F')
            {
                kilometersCounter += 10;
                map[carPositionRow, carPositionCol] = '.';
                carPositionRow--;
                map[carPositionRow, carPositionCol] = 'C';
                Console.WriteLine($"Racing car {carName} finished the stage!");
                break;
            }
        }
    }
    else if (command == "right")
    {
        if (IndexChecker(carPositionRow, carPositionCol)
            && IndexChecker(carPositionRow, carPositionCol + 1))
        {
            if (map[carPositionRow, carPositionCol + 1] == '.')
            {
                kilometersCounter += 10;
                map[carPositionRow, carPositionCol] = '.';
                carPositionCol++;
                map[carPositionRow, carPositionCol] = 'C';
            }
            else if (map[carPositionRow, carPositionCol + 1] == 'T')
            {
                kilometersCounter += 30;
                map[carPositionRow, carPositionCol] = '.';
                carPositionCol++;
                if (carPositionRow == firstTunnelRow && carPositionCol == firstTunnelCol)
                {
                    map[carPositionRow, carPositionCol] = '.';
                    carPositionRow = secondTunnelRow;
                    carPositionCol = secondTunnelCol;
                    map[carPositionRow, carPositionCol] = 'C';
                }
                else if (carPositionRow == secondTunnelRow && carPositionCol == secondTunnelCol)
                {
                    map[carPositionRow, carPositionCol] = '.';
                    carPositionRow = firstTunnelRow;
                    carPositionCol = firstTunnelCol;
                    map[carPositionRow, carPositionCol] = 'C';
                }
            }
            else if (map[carPositionRow, carPositionCol + 1] == 'F')
            {
                kilometersCounter += 10;
                map[carPositionRow, carPositionCol] = '.';
                carPositionCol++;
                map[carPositionRow, carPositionCol] = 'C';
                Console.WriteLine($"Racing car {carName} finished the stage!");
                break;
            }
        }
    }
    else if (command == "down")
    {
        if (IndexChecker(carPositionRow, carPositionCol)
            && IndexChecker(carPositionRow + 1, carPositionCol))
        {
            if (map[carPositionRow + 1, carPositionCol] == '.')
            {
                kilometersCounter += 10;
                map[carPositionRow, carPositionCol] = '.';
                carPositionRow++;
                map[carPositionRow, carPositionCol] = 'C';
            }
            else if (map[carPositionRow + 1, carPositionCol] == 'T')
            {
                kilometersCounter += 30;
                map[carPositionRow, carPositionCol] = '.';
                carPositionRow++;
                if (carPositionRow == firstTunnelRow && carPositionCol == firstTunnelCol)
                {
                    map[carPositionRow, carPositionCol] = '.';
                    carPositionRow = secondTunnelRow;
                    carPositionCol = secondTunnelCol;
                    map[carPositionRow, carPositionCol] = 'C';
                }
                else if (carPositionRow == secondTunnelRow && carPositionCol == secondTunnelCol)
                {
                    map[carPositionRow, carPositionCol] = '.';
                    carPositionRow = firstTunnelRow;
                    carPositionCol = firstTunnelCol;
                    map[carPositionRow, carPositionCol] = 'C';
                }
            }
            else if (map[carPositionRow + 1, carPositionCol] == 'F')
            {
                kilometersCounter += 10;
                map[carPositionRow, carPositionCol] = '.';
                carPositionRow++;
                map[carPositionRow, carPositionCol] = 'C';
                Console.WriteLine($"Racing car {carName} finished the stage!");
                break;
            }
        }
    }
    else if (command == "left")
    {
        if (IndexChecker(carPositionRow, carPositionCol)
            && IndexChecker(carPositionRow, carPositionCol - 1))
        {
            if (map[carPositionRow, carPositionCol - 1] == '.')
            {
                kilometersCounter += 10;
                map[carPositionRow, carPositionCol] = '.';
                carPositionCol--;
                map[carPositionRow, carPositionCol] = 'C';
            }
            else if (map[carPositionRow, carPositionCol - 1] == 'T')
            {
                kilometersCounter += 30;
                map[carPositionRow, carPositionCol] = '.';
                carPositionCol--;
                if (carPositionRow == firstTunnelRow && carPositionCol == firstTunnelCol)
                {
                    map[carPositionRow, carPositionCol] = '.';
                    carPositionRow = secondTunnelRow;
                    carPositionCol = secondTunnelCol;
                    map[carPositionRow, carPositionCol] = 'C';
                }
                else if (carPositionRow == secondTunnelRow && carPositionCol == secondTunnelCol)
                {
                    map[carPositionRow, carPositionCol] = '.';
                    carPositionRow = firstTunnelRow;
                    carPositionCol = firstTunnelCol;
                    map[carPositionRow, carPositionCol] = 'C';
                }
            }
            else if (map[carPositionRow, carPositionCol - 1] == 'F')
            {
                kilometersCounter += 10;
                map[carPositionRow, carPositionCol] = '.';
                carPositionCol--;
                map[carPositionRow, carPositionCol] = 'C';
                Console.WriteLine($"Racing car {carName} finished the stage!");
                break;
            }
        }
    }
}

Console.WriteLine($"Distance covered {kilometersCounter} km.");
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
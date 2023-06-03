using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

string[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(dimensions[0]);
int cols = int.Parse(dimensions[1]);
char[,] map = new char[rows, cols];
int manPositionRow = 0;
int manPositionCol = 0; 

for (int row = 0; row < rows; row++)
{
    string data = Console.ReadLine();
    data = data.Replace(" ", "");


    for (int col = 0; col < cols; col++)
    {
        map[row, col] = data[col];

        if (map[row, col] == 'B')
        {
            manPositionRow = row;
            manPositionCol = col;
        }
    }
}
int touchedManCounter = 0;
int movesCounter = 0;

while (true)
{
    string command = Console.ReadLine();

    if (command == "Finish")
    {
        break;
    }
    else if (command == "up")
    {
        if (IndexChecker(manPositionRow, manPositionCol)
            && IndexChecker(manPositionRow - 1, manPositionCol))
        {
            if (map[manPositionRow - 1, manPositionCol] == 'O')
            {
                continue;
            }
            else if (map[manPositionRow - 1, manPositionCol] == 'P')
            {
                movesCounter++;
                map[manPositionRow, manPositionCol] = '-';
                manPositionRow--;
                touchedManCounter++;
                map[manPositionRow, manPositionCol] = 'B';
            }
            else
            {
                movesCounter++;
                map[manPositionRow, manPositionCol] = '-';
                manPositionRow--;
                map[manPositionRow, manPositionCol] = 'B';
            }

            if (touchedManCounter == 3)
            {
                break;
            }
        }
    }
    else if (command == "right")
    {
        if (IndexChecker(manPositionRow, manPositionCol)
            && IndexChecker(manPositionRow, manPositionCol + 1))
        {
            if (map[manPositionRow, manPositionCol + 1] == 'O')
            {
                continue;
            }
            else if (map[manPositionRow, manPositionCol + 1] == 'P')
            {
                movesCounter++;
                map[manPositionRow, manPositionCol] = '-';
                manPositionCol++;
                touchedManCounter++;
                map[manPositionRow, manPositionCol] = 'B';
            }
            else
            {
                movesCounter++;
                map[manPositionRow, manPositionCol] = '-';
                manPositionCol++;
                map[manPositionRow, manPositionCol] = 'B';
            }

            if (touchedManCounter == 3)
            {
                break;
            }
        }
    }
    else if (command == "down")
    {
        if (IndexChecker(manPositionRow, manPositionCol)
            && IndexChecker(manPositionRow + 1, manPositionCol))
        {
            if (map[manPositionRow + 1, manPositionCol] == 'O')
            {
                continue;
            }
            else if (map[manPositionRow + 1, manPositionCol] == 'P')
            {
                movesCounter++;
                map[manPositionRow, manPositionCol] = '-';
                manPositionRow++;
                touchedManCounter++;
                map[manPositionRow, manPositionCol] = 'B';
            }
            else
            {
                movesCounter++;
                map[manPositionRow, manPositionCol] = '-';
                manPositionRow++;
                map[manPositionRow, manPositionCol] = 'B';
            }

            if (touchedManCounter == 3)
            {
                break;
            }
        }
    }
    else if (command == "left")
    {
        if (IndexChecker(manPositionRow, manPositionCol)
            && IndexChecker(manPositionRow, manPositionCol - 1))
        {
            if (map[manPositionRow, manPositionCol - 1] == 'O')
            {
                continue;
            }
            else if (map[manPositionRow, manPositionCol - 1] == 'P')
            {
                movesCounter++;
                map[manPositionRow, manPositionCol] = '-';
                manPositionCol--;
                touchedManCounter++;
                map[manPositionRow, manPositionCol] = 'B';
            }
            else
            {
                movesCounter++;
                map[manPositionRow, manPositionCol] = '-';
                manPositionCol--;
                map[manPositionRow, manPositionCol] = 'B';
            }

            if (touchedManCounter == 3)
            {
                break;
            }
        }
    }
}
Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {touchedManCounter} Moves made: {movesCounter}");


bool IndexChecker (int rowIndex, int colIndex)
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
using System.Drawing;

string[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(dimensions[0]);
int cols = int.Parse(dimensions[1]);
char[,] map = new char[rows, cols];
int manPositionRow = 0;
int manPositionCol = 0; 

for (int row = 0; row < rows; row++)
{
    string data = Console.ReadLine();

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
        
    }
    else if (command == "right")
    {

    }
    else if (command == "down")
    {

    }
    else if (command == "left")
    {

    }
}
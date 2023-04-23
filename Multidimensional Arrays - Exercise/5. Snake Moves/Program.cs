using System.Security;

int[] matrixInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = matrixInfo[0];
int cols = matrixInfo[1];
char[,] matrix = new char[rows, cols];

int turn = 1;

string input = Console.ReadLine();
Queue<char> text = new(input);
int colStart = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    if (row % 2 == 0)
    {
        for (int col = colStart; col < matrix.GetLength(1); col++)
        {
            char currentSymbol = text.Dequeue();
            matrix[row, col] = currentSymbol;
            text.Enqueue(currentSymbol);
        }
    }
    else
    {
        for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
        {
            char currentSymbol = text.Dequeue();
            matrix[row, col] = currentSymbol;
            text.Enqueue(currentSymbol);
        }
    }

    
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}
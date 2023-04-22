int[] matrixInfo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int rows = matrixInfo[0];
int cols = matrixInfo[1];
int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    char[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
    }
}
int mainCounter = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (col + 1 < matrix.GetLength(1) && row + 1 < matrix.GetLength(0))
        {
            if (matrix[row, col] == matrix[row, col + 1])
            {
                if (matrix[row + 1, col] == matrix[row, col] && matrix[row + 1, col + 1] == matrix[row, col])
                {
                    mainCounter++;
                }
            }
        }
    }
}
Console.WriteLine(mainCounter);
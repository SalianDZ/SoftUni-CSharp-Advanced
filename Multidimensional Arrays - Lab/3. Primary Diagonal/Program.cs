int matrixSize = int.Parse(Console.ReadLine());
int[,] matrix = new int[matrixSize, matrixSize];
int sum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = data[col];
    }
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = row; col < matrix.GetLength(1); col++)
    {
        sum += matrix[row, col];
        break;
    }
}
Console.WriteLine(sum);
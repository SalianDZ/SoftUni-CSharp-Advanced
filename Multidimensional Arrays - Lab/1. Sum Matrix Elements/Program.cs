int[] matrixInfo = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = matrixInfo[0];
int cols = matrixInfo[1];
int[,] matrix = new int[rows, cols];
int sum = 0;

for (int row = 0; row < rows; row++)
{
	int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
	for (int col = 0; col < cols; col++)
	{
		matrix[row, col] = data[col];
		sum += matrix[row, col];
    }
}
Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);
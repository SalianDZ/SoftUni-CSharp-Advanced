using System.Globalization;

int size = int.Parse(Console.ReadLine());
int[,] matrix = new int[size, size];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
	for (int col = 0; col < matrix.GetLength(1); col++)
	{
		matrix[row, col] = data[col];
	}
}

int leftDiagonalSum = 0;
int rightDiagonalSum = 0;

for (int rowAndCol = 0; rowAndCol < matrix.GetLength(0); rowAndCol++)
{
	leftDiagonalSum += matrix[rowAndCol, rowAndCol];
}

int index = matrix.GetLength(1);
for (int row = 0; row < matrix.GetLength(0); row++)
{
	if (index < 0)
	{
		break;
	}
	for (int col = index - 1; col >= 0; col--)
	{
		rightDiagonalSum += matrix[row, col];
		break;
	}
	index--;
}
int totalSum = leftDiagonalSum - rightDiagonalSum;
Console.WriteLine(Math.Abs(totalSum));

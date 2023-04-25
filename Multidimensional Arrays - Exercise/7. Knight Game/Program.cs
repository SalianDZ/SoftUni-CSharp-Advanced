int size = int.Parse(Console.ReadLine());

string[,] matrix = new string[size, size];
for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] data = Console.ReadLine().Split("");
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = data[col];
    }
}
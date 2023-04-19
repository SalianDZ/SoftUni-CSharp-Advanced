int matrixSize = int.Parse(Console.ReadLine());
char[,] matrix = new char[matrixSize, matrixSize];
bool isFound = false;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string currentInput = Console.ReadLine();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = currentInput[col];
    }
}
char searchedSymbol = char.Parse(Console.ReadLine());

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == searchedSymbol)
        {
            Console.WriteLine($"({row}, {col})");
            isFound = true;
            return;
        }
    }
}

if (!isFound)
{
    Console.WriteLine($"{searchedSymbol} does not occur in the matrix");
}
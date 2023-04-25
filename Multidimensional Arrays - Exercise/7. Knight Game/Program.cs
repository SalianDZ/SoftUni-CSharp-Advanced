int size = int.Parse(Console.ReadLine());


char[,] matrix = new char[size, size];
for (int row = 0; row < matrix.GetLength(0); row++)
{
    string data = Console.ReadLine();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = data[col];
    }
}

if (size <= 2)
{
    Console.WriteLine(0);
    return;
}
int counter = 0;

//Трябва да дебъгна и да намеря грешката
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == 'K')
        {
            if (col - 2 >= 0 && row - 1 >= 0)
            {
                if (matrix[row - 1, col - 2] == 'K')
                {
                    matrix[row - 1, col - 2] = '0';
                    counter++;
                    continue;
                }
            }
            if (col - 2 >= 0 && row + 1 < matrix.GetLength(0))
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    matrix[row + 1, col - 2] = '0';
                    counter++;
                    continue;
                }
            }
            if (row - 2 >= 0 && col - 1 >= 0)
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    matrix[row - 2, col - 1] = '0';
                    counter++;
                    continue;
                }
            }
            if (row - 2 >= 0 && col + 1 < matrix.GetLength(1))
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    matrix[row - 2, col + 1] = '0';
                    counter++;
                    continue;
                }
            }
            if (col + 2 < matrix.GetLength(1) && row - 1 >= 0)
            {
                if (matrix[row - 1, col + 2] == 'K')
                {
                    matrix[row - 1, col + 2] = '0';
                    counter++;
                    continue;
                }
            }
            if (col + 2 < matrix.GetLength(1) && row + 1 < matrix.GetLength(0))
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    matrix[row + 1, col + 2] = '0';
                    counter++;
                    continue;
                }
            }
            if (row + 2 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1))
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    matrix[row + 2, col + 1] = '0';
                    counter++;
                    continue;
                }
            }
            if (row + 2 < matrix.GetLength(0) && col - 1 >= 0)
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    matrix[row + 2, col - 1] = '0';
                    counter++;
                    continue;
                }
            }
        }
    }
}

Console.WriteLine(counter);

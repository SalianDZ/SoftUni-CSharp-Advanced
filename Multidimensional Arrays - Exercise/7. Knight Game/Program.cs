int size = int.Parse(Console.ReadLine());

if (size< 3)
{
    Console.WriteLine(0);
    return;
}

char[,] matrix = new char[size, size];

for (int row = 0; row < size; row++)
{
    string chars = Console.ReadLine();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = chars[col];
    }
}

int knightsRemoved = 0;

while (true)
{
    int countMostAttacking = 0;
    int rowMostAttacking = 0;
    int colMostAttacking = 0;

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            if (matrix[row,col] == 'K')
            {
                int attackedKnights = CountAttackedKnights(row, col);

                if (countMostAttacking < attackedKnights)
                {
                    countMostAttacking = attackedKnights;
                    rowMostAttacking = row;
                    colMostAttacking = col;
                }
            }
        }
    }

    if (countMostAttacking == 0)
    {
        break;
    }
    else
    {
        matrix[rowMostAttacking, colMostAttacking] = '0'; 
        knightsRemoved++;
    }
}
Console.WriteLine(knightsRemoved);



int CountAttackedKnights(int row, int col)
{
    int attackedKnights = 0;

    if (isCellValid(row - 1, col - 2))
    {
        if (matrix[row - 1, col - 2] == 'K')
        {
            attackedKnights++;
        }
    }

    if (isCellValid(row + 1, col - 2))
    {
        if (matrix[row + 1, col - 2] == 'K')
        {
            attackedKnights++;
        }
    }

    if (isCellValid(row - 1, col + 2))
    {
        if (matrix[row - 1, col + 2] == 'K')
        {
            attackedKnights++;
        }
    }

    if (isCellValid(row + 1, col + 2))
    {
        if (matrix[row + 1, col + 2] == 'K')
        {
            attackedKnights++;
        }
    }

    if (isCellValid(row - 2, col - 1))
    {
        if (matrix[row - 2, col - 1] == 'K')
        {
            attackedKnights++;
        }
    }

    if (isCellValid(row - 2, col + 1))
    {
        if (matrix[row - 2, col + 1] == 'K')
        {
            attackedKnights++;
        }
    }

    if (isCellValid(row + 2, col - 1))
    {
        if (matrix[row + 2, col - 1] == 'K')
        {
            attackedKnights++;
        }
    }

    if (isCellValid(row + 2, col + 1))
    {
        if (matrix[row + 2, col + 1] == 'K')
        {
            attackedKnights++;
        }
    }

    return attackedKnights;
}


bool isCellValid(int row, int col)
{
    return row >= 0 && row < size && col >= 0 && col < size;
}
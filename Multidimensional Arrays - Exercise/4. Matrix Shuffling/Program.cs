int[] matrixInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = matrixInfo[0];
int cols = matrixInfo[1];
string[,] matrix = new string[rows, cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] data = Console.ReadLine().Split();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = data[col];
    }
}

while (true)
{
    string[] command = Console.ReadLine().Split();
    
    if (command[0] == "END")
    {
        break;
    }
    else if (command[0] == "swap" && command.Length == 5)
    {
        int row1 = int.Parse(command[1]);
        int col1 = int.Parse(command[2]);
        int row2 = int.Parse(command[3]);
        int col2 = int.Parse(command[4]);

        if (row1 >= 0 && row2 < matrix.GetLength(0) &&
            col1 >= 0 && col2 < matrix.GetLength(1))
        {
            string temp = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = temp;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
            continue;
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
        continue;
    }
    
}
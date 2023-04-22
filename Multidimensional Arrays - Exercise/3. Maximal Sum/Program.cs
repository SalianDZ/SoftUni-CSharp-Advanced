using System.Diagnostics.Metrics;
using System.Net;


int[] matrixInfo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int rows = matrixInfo[0];
int cols = matrixInfo[1];
int[,] matrix = new int[rows, cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = data[col];
    }
}
int sum = 0;
int colsCounter = 0;
int rowsCounter = 0;
int sumCounter = 0;

Dictionary<int, SumInfo> matrixSum = new Dictionary<int, SumInfo>();

int tempcol = 0; 
int temprol = 0;
int rowsCopy = rows;
int additionalTempRol = -1;

for (int row = temprol; row < matrix.GetLength(0); row++)
{
    rowsCounter++;
    colsCounter = 0;

    for (int col = tempcol; col < matrix.GetLength(1); col++)
    {
        colsCounter++;
        sum += matrix[row, col];
        sumCounter++;
        if (sumCounter == 9)
        {
            sumCounter = 0;
            if (matrixSum.Any(x => x.Key >= sum))
            {
                tempcol++;
                sum = 0;
                break;
            }
            else
            {
                int[] upperDigits = { matrix[row - 2, col - 2], matrix[row - 2, col - 1], matrix[row - 2, col] };
                int[] middleDigits = { matrix[row - 1, col - 2], matrix[row - 1, col - 1], matrix[row - 1, col] };
                int[] lowerDigits = { matrix[row, col - 2], matrix[row, col - 1], matrix[row, col] };
                matrixSum[sum] = new(upperDigits, middleDigits, lowerDigits);
                tempcol++;
                sum = 0;
                break;
            }
        }
        if (colsCounter == 3)
        {
            colsCounter = 0;
            break;
        }
    }
    if (rowsCounter == 3)
    {
        rowsCounter = 0;
        if (tempcol == cols - 2)
        {
            if (rowsCopy > 3)
            {
                temprol++;
                rowsCopy--;
                additionalTempRol++;
                tempcol = 0;
            }
            else
            {
                int maxSum = matrixSum.Keys.Max();
                Console.WriteLine($"Sum = {maxSum}");
                Console.WriteLine(String.Join(" ", matrixSum[maxSum].UpperDigits));
                Console.WriteLine(String.Join(" ", matrixSum[maxSum].MiddleDigits));
                Console.WriteLine(String.Join(" ", matrixSum[maxSum].LowerDigits));
                return;
            }

        }

        row = additionalTempRol;
    }
}

public class SumInfo
{
    public SumInfo(int[] upperDigits, int[] middleDigits, int[] lowerDigits)
    {
        UpperDigits = upperDigits;
        MiddleDigits = middleDigits;
        LowerDigits = lowerDigits;
    }

    public int[] UpperDigits { get; set; }
    public int[] MiddleDigits { get; set; }
    public int[] LowerDigits { get; set; }
}


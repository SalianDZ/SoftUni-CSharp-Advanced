using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Beaver_at_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] map = new char[size, size];
            int beaverPositionRow = 0;
            int beaverPositionCol = 0;
            int woodBranchCounter = 0;


            for (int row = 0; row < size; row++)
            {
                string data = Console.ReadLine();
                data = data.Replace(" ", "");

                for (int col = 0; col < size; col++)
                {
                    map[row, col] = data[col];

                    if (map[row, col] == 'B')
                    {
                        beaverPositionRow = row;
                        beaverPositionCol = col;
                    }
                    if (char.IsLower(map[row, col]))
                    {
                        woodBranchCounter++;
                    }
                }
            }
            bool hasWon = true;
            List<char> woodBranches = new List<char>();

            while (true)
            {
                if (woodBranchCounter == 0)
                {
                    break;
                }
                string command = Console.ReadLine();

                if (command == "end")
                {
                    hasWon = false;
                    break;
                }
                else if (command == "up")
                {
                    if (IndexChecker(beaverPositionRow, beaverPositionCol)
                        && IndexChecker(beaverPositionRow - 1, beaverPositionCol))
                    {
                        if (map[beaverPositionRow - 1, beaverPositionCol] == '-')
                        {
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionRow--;
                            map[beaverPositionRow, beaverPositionCol] = 'B';
                        }
                        else if (char.IsLower(map[beaverPositionRow - 1, beaverPositionCol]))
                        {
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionRow--;
                            woodBranches.Add(map[beaverPositionRow, beaverPositionCol]);
                            woodBranchCounter--;
                            map[beaverPositionRow, beaverPositionCol] = 'B';

                            if (woodBranchCounter <= 0)
                            {
                                break;
                            }
                        }
                        else if (map[beaverPositionRow - 1, beaverPositionCol] == 'F')
                        {
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionRow--;
                            map[beaverPositionRow, beaverPositionCol] = 'B';

                            if (beaverPositionRow == 0)
                            {
                                map[beaverPositionRow, beaverPositionCol] = '-';
                                beaverPositionRow = map.GetLength(0) - 1;
                                if (char.IsLower(map[beaverPositionRow, beaverPositionCol]))
                                {
                                    woodBranches.Add(map[beaverPositionRow, beaverPositionCol]);
                                    woodBranchCounter--;
                                    map[beaverPositionRow, beaverPositionCol] = 'B';
                                    if (woodBranchCounter <= 0)
                                    {
                                        break;
                                    }
                                    continue;
                                }
                                map[beaverPositionRow, beaverPositionCol] = 'B';
                                continue;
                            }
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionRow = 0;
                            if (char.IsLower(map[beaverPositionRow, beaverPositionCol]))
                            {
                                woodBranches.Add(map[beaverPositionRow, beaverPositionCol]);
                                woodBranchCounter--;
                                map[beaverPositionRow, beaverPositionCol] = 'B';
                                if (woodBranchCounter <= 0)
                                {
                                    break;
                                }
                                continue;
                            }
                            map[beaverPositionRow, beaverPositionCol] = 'B';
                        }
                    }
                    else
                    {
                        if (woodBranches.Any())
                        {
                            woodBranches.RemoveAt(woodBranches.Count - 1);
                        }
                    }
                }
                else if (command == "right")
                {
                    if (IndexChecker(beaverPositionRow, beaverPositionCol)
                        && IndexChecker(beaverPositionRow, beaverPositionCol + 1))
                    {
                        if (map[beaverPositionRow, beaverPositionCol + 1] == '-')
                        {
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionCol++;
                            map[beaverPositionRow, beaverPositionCol] = 'B';
                        }
                        else if (char.IsLower(map[beaverPositionRow, beaverPositionCol + 1]))
                        {
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionCol++;
                            woodBranches.Add(map[beaverPositionRow, beaverPositionCol]);
                            woodBranchCounter--;
                            map[beaverPositionRow, beaverPositionCol] = 'B';

                            if (woodBranchCounter <= 0)
                            {
                                break;
                            }
                        }
                        else if(map[beaverPositionRow, beaverPositionCol + 1] == 'F')
                        {
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionCol++;
                            map[beaverPositionRow, beaverPositionCol] = 'B';

                            if (beaverPositionCol == map.GetLength(1) - 1)
                            {
                                map[beaverPositionRow, beaverPositionCol] = '-';
                                beaverPositionCol = 0;
                                if (char.IsLower(map[beaverPositionRow, beaverPositionCol]))
                                {
                                    woodBranches.Add(map[beaverPositionRow, beaverPositionCol]);
                                    map[beaverPositionRow, beaverPositionCol] = 'B';
                                    woodBranchCounter--;
                                    if (woodBranchCounter <= 0)
                                    {
                                        break;
                                    }
                                    continue;
                                }
                                map[beaverPositionRow, beaverPositionCol] = 'B';
                                continue;
                            }
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionCol = map.GetLength(1) - 1;
                            if (char.IsLower(map[beaverPositionRow, beaverPositionCol]))
                            {
                                woodBranches.Add(map[beaverPositionRow, beaverPositionCol]);
                                woodBranchCounter--;
                                map[beaverPositionRow, beaverPositionCol] = 'B';
                                if (woodBranchCounter <= 0)
                                {
                                    break;
                                }
                                continue;
                            }
                            map[beaverPositionRow, beaverPositionCol] = 'B';
                        }
                    }
                    else
                    {
                        if (woodBranches.Any())
                        {
                            woodBranches.RemoveAt(woodBranches.Count - 1);
                        }
                    }
                }
                else if (command == "down")
                {
                    if (IndexChecker(beaverPositionRow, beaverPositionCol)
                        && IndexChecker(beaverPositionRow + 1, beaverPositionCol))
                    {
                        if (map[beaverPositionRow + 1, beaverPositionCol] == '-')
                        {
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionRow++;
                            map[beaverPositionRow, beaverPositionCol] = 'B';
                        }
                        else if (char.IsLower(map[beaverPositionRow + 1, beaverPositionCol]))
                        {
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionRow++;
                            woodBranches.Add(map[beaverPositionRow, beaverPositionCol]);
                            woodBranchCounter--;
                            map[beaverPositionRow, beaverPositionCol] = 'B';

                            if (woodBranchCounter <= 0)
                            {
                                break;
                            }
                        }
                        else if (map[beaverPositionRow + 1, beaverPositionCol] == 'F')
                        {
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionRow++;
                            map[beaverPositionRow, beaverPositionCol] = 'B';

                            if (beaverPositionRow == map.GetLength(0) - 1)
                            {
                                map[beaverPositionRow, beaverPositionCol] = '-';
                                beaverPositionRow = 0;
                                if (char.IsLower(map[beaverPositionRow, beaverPositionCol]))
                                {
                                    woodBranches.Add(map[beaverPositionRow, beaverPositionCol]);
                                    woodBranchCounter--;
                                    map[beaverPositionRow, beaverPositionCol] = 'B';
                                    if (woodBranchCounter <= 0)
                                    {
                                        break;
                                    }
                                    continue;
                                }
                                map[beaverPositionRow, beaverPositionCol] = 'B';
                                continue;
                            }
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionRow = map.GetLength(0) - 1;
                            if (char.IsLower(map[beaverPositionRow, beaverPositionCol]))
                            {
                                woodBranches.Add(map[beaverPositionRow, beaverPositionCol]);
                                woodBranchCounter--;
                                map[beaverPositionRow, beaverPositionCol] = 'B';
                                if (woodBranchCounter <= 0)
                                {
                                    break;
                                }
                                continue;
                            }
                            map[beaverPositionRow, beaverPositionCol] = 'B';
                        }
                    }
                    else
                    {
                        if (woodBranches.Any())
                        {
                            woodBranches.RemoveAt(woodBranches.Count - 1);
                        }
                    }
                }
                else if (command == "left")
                {
                    if (IndexChecker(beaverPositionRow, beaverPositionCol)
                        && IndexChecker(beaverPositionRow, beaverPositionCol - 1))
                    {
                        if (map[beaverPositionRow, beaverPositionCol - 1] == '-')
                        {
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionCol--;
                            map[beaverPositionRow, beaverPositionCol] = 'B';
                        }
                        else if (char.IsLower(map[beaverPositionRow, beaverPositionCol - 1]))
                        {
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionCol--;
                            woodBranches.Add(map[beaverPositionRow, beaverPositionCol]);
                            woodBranchCounter--;
                            map[beaverPositionRow, beaverPositionCol] = 'B';

                            if (woodBranchCounter <= 0)
                            {
                                break;
                            }
                        }
                        else if (map[beaverPositionRow, beaverPositionCol - 1] == 'F')
                        { 
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionCol--;
                            map[beaverPositionRow, beaverPositionCol] = 'B';

                            if (beaverPositionCol == 0)
                            {
                                map[beaverPositionRow, beaverPositionCol] = '-';
                                beaverPositionCol = map.GetLength(1) - 1;
                                if (char.IsLower(map[beaverPositionRow, beaverPositionCol]))
                                {
                                    woodBranches.Add(map[beaverPositionRow, beaverPositionCol]);
                                    woodBranchCounter--;
                                    map[beaverPositionRow, beaverPositionCol] = 'B';
                                    if (woodBranchCounter <= 0)
                                    {
                                        break;
                                    }
                                    continue;
                                }
                                map[beaverPositionRow, beaverPositionCol] = 'B';
                                continue;
                            }
                            map[beaverPositionRow, beaverPositionCol] = '-';
                            beaverPositionCol = 0;
                            if (char.IsLower(map[beaverPositionRow, beaverPositionCol]))
                            {
                                woodBranches.Add(map[beaverPositionRow, beaverPositionCol]);
                                map[beaverPositionRow, beaverPositionCol] = 'B';
                                if (woodBranchCounter <= 0)
                                {
                                    break;
                                }
                                continue;
                            }
                            map[beaverPositionRow, beaverPositionCol] = 'B';
                        }
                    }
                    else
                    {
                        if (woodBranches.Any())
                        {
                            woodBranches.RemoveAt(woodBranches.Count - 1);
                        }
                    }
                }
            }

            if (hasWon)
            {
                Console.WriteLine($"The Beaver successfully collect {woodBranches.Count} wood branches: {string.Join(", ", woodBranches)}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {woodBranchCounter} branches left.");
            }

            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    Console.Write(map[row, col] + " ");
                }
                Console.WriteLine();
            }



            bool IndexChecker(int rowIndex, int colIndex)
            {
                if (rowIndex >= 0 && rowIndex < map.GetLength(0)
                    && colIndex >= 0 && colIndex < map.GetLength(1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

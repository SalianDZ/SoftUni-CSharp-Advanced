using System;

namespace _02._Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] map = new char[size, size];
            int officerRow = 0;
            int officerCol = 0;
            string mirrorCoordinates = string.Empty;

            for (int row = 0; row < size; row++)
            {
                string data = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    map[row, col] = data[col];

                    if (map[row, col] == 'M')
                    {
                        mirrorCoordinates += row.ToString();
                        mirrorCoordinates += col.ToString();
                    }
                    if (map[row, col] == 'A')
                    {
                        officerRow = row;
                        officerCol = col;
                    }
                }
            }
            int firstMirrorRow = 0;
            int firstMirrorCol = 0;
            int secondMirrorRow =0;
            int secondMirrorCol = 0;

            if (mirrorCoordinates != string.Empty)
            {
                firstMirrorRow = int.Parse(mirrorCoordinates[0].ToString());
                firstMirrorCol = int.Parse(mirrorCoordinates[1].ToString());
                secondMirrorRow = int.Parse(mirrorCoordinates[2].ToString());
                secondMirrorCol = int.Parse(mirrorCoordinates[3].ToString());
            }

            int points = 0;
            bool hasWon = true;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    if (IndexChecker(officerRow, officerCol)
                        && IndexChecker(officerRow - 1, officerCol))
                    {
                        if (map[officerRow - 1, officerCol] == '-')
                        {
                            map[officerRow, officerCol] = '-';
                            officerRow--;
                            map[officerRow, officerCol] = 'A';
                        }
                        else if (map[officerRow - 1, officerCol] == 'M')
                        {
                            map[officerRow, officerCol] = '-';
                            officerRow--;
                            if (officerRow == firstMirrorRow && officerCol == firstMirrorCol)
                            {
                                map[officerRow, officerCol] = '-';
                                officerRow = secondMirrorRow;
                                officerCol = secondMirrorCol;
                                map[officerRow, officerCol] = 'A';
                            }
                            else if (officerRow == secondMirrorRow && officerCol == secondMirrorCol)
                            {
                                map[officerRow, officerCol] = '-';
                                officerRow = firstMirrorRow;
                                officerCol = firstMirrorCol;
                                map[officerRow, officerCol] = 'A';
                            }
                        }
                        else
                        {
                            map[officerRow, officerCol] = '-';
                            officerRow--;
                            int currentpoints = int.Parse(map[officerRow, officerCol].ToString());
                            points += currentpoints;
                            map[officerRow, officerCol] = 'A';

                            if (points >= 65)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        hasWon = false;
                        map[officerRow, officerCol] = '-';
                        break;
                    }
                }
                else if (command == "right")
                {
                    if (IndexChecker(officerRow, officerCol)
                        && IndexChecker(officerRow, officerCol + 1))
                    {
                        if (map[officerRow, officerCol + 1] == '-')
                        {
                            map[officerRow, officerCol] = '-';
                            officerCol++;
                            map[officerRow, officerCol] = 'A';
                        }
                        else if (map[officerRow, officerCol + 1] == 'M')
                        {
                            map[officerRow, officerCol] = '-';
                            officerCol++;
                            if (officerRow == firstMirrorRow && officerCol == firstMirrorCol)
                            {
                                map[officerRow, officerCol] = '-';
                                officerRow = secondMirrorRow;
                                officerCol = secondMirrorCol;
                                map[officerRow, officerCol] = 'A';
                            }
                            else if (officerRow == secondMirrorRow && officerCol == secondMirrorCol)
                            {
                                map[officerRow, officerCol] = '-';
                                officerRow = firstMirrorRow;
                                officerCol = firstMirrorCol;
                                map[officerRow, officerCol] = 'A';
                            }
                        }
                        else
                        {
                            map[officerRow, officerCol] = '-';
                            officerCol++;
                            int currentpoints = int.Parse(map[officerRow, officerCol].ToString());
                            points += currentpoints;
                            map[officerRow, officerCol] = 'A';

                            if (points >= 65)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        hasWon = false;
                        map[officerRow, officerCol] = '-';
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (IndexChecker(officerRow, officerCol)
                        && IndexChecker(officerRow + 1, officerCol))
                    {
                        if (map[officerRow + 1, officerCol] == '-')
                        {
                            map[officerRow, officerCol] = '-';
                            officerRow++;
                            map[officerRow, officerCol] = 'A';
                        }
                        else if (map[officerRow + 1, officerCol] == 'M')
                        {
                            map[officerRow, officerCol] = '-';
                            officerRow++;
                            if (officerRow == firstMirrorRow && officerCol == firstMirrorCol)
                            {
                                map[officerRow, officerCol] = '-';
                                officerRow = secondMirrorRow;
                                officerCol = secondMirrorCol;
                                map[officerRow, officerCol] = 'A';
                            }
                            else if (officerRow == secondMirrorRow && officerCol == secondMirrorCol)
                            {
                                map[officerRow, officerCol] = '-';
                                officerRow = firstMirrorRow;
                                officerCol = firstMirrorCol;
                                map[officerRow, officerCol] = 'A';
                            }
                        }
                        else
                        {
                            map[officerRow, officerCol] = '-';
                            officerRow++;
                            int currentpoints = int.Parse(map[officerRow, officerCol].ToString());
                            points += currentpoints;
                            map[officerRow, officerCol] = 'A';

                            if (points >= 65)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        hasWon = false;
                        map[officerRow, officerCol] = '-';
                        break;
                    }
                }
                else if (command == "left")
                {
                    if (IndexChecker(officerRow, officerCol)
                        && IndexChecker(officerRow, officerCol - 1))
                    {
                        if (map[officerRow, officerCol - 1] == '-')
                        {
                            map[officerRow, officerCol] = '-';
                            officerCol--;
                            map[officerRow, officerCol] = 'A';
                        }
                        else if (map[officerRow, officerCol - 1] == 'M')
                        {
                            map[officerRow, officerCol] = '-';
                            officerCol--;
                            if (officerRow == firstMirrorRow && officerCol == firstMirrorCol)
                            {
                                map[officerRow, officerCol] = '-';
                                officerRow = secondMirrorRow;
                                officerCol = secondMirrorCol;
                                map[officerRow, officerCol] = 'A';
                            }
                            else if (officerRow == secondMirrorRow && officerCol == secondMirrorCol)
                            {
                                map[officerRow, officerCol] = '-';
                                officerRow = firstMirrorRow;
                                officerCol = firstMirrorCol;
                                map[officerRow, officerCol] = 'A';
                            }
                        }
                        else
                        {
                            map[officerRow, officerCol] = '-';
                            officerCol--;
                            int currentpoints = int.Parse(map[officerRow, officerCol].ToString());
                            points += currentpoints;
                            map[officerRow, officerCol] = 'A';

                            if (points >= 65)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        hasWon = false;
                        map[officerRow, officerCol] = '-';
                        break;
                    }
                }
            }

            if (hasWon)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
            }
            else
            {
                Console.WriteLine("I do not need more swords!");
            }

            Console.WriteLine($"The king paid {points} gold coins.");


            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    Console.Write(map[row, col]);
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

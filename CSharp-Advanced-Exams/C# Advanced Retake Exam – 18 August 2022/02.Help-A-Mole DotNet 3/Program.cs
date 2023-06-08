using System;
using System.Linq;
using System.Collections.Generic;
namespace _02.Help_A_Mole_DotNet_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] map = new char[size, size];
            int molePositionRow = 0;
            int molePositionCol = 0;
            string tunnelCordinates = string.Empty;

            for (int row = 0; row < size; row++)
            {
                string data = Console.ReadLine();


                for (int col = 0; col < size; col++)
                {
                    map[row, col] = data[col];

                    if (map[row, col] == 'S')
                    {
                        tunnelCordinates += row.ToString();
                        tunnelCordinates += col.ToString();
                    }
                    if (map[row, col] == 'M')
                    {
                        molePositionRow = row;
                        molePositionCol = col;
                    }
                }
            }

            int firstTunnelRow = int.Parse(tunnelCordinates[0].ToString());
            int firstTunnelCol = int.Parse(tunnelCordinates[1].ToString());
            int secondTunnelRow = int.Parse(tunnelCordinates[2].ToString());
            int secondTunnelCol = int.Parse(tunnelCordinates[3].ToString());

            int points = 0;
            bool hasWon = true;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    hasWon = false;
                    break;
                }
                else if (command == "up")
                {
                    if (IndexChecker(molePositionRow, molePositionCol)
                        && IndexChecker(molePositionRow - 1, molePositionCol))
                    {
                        if (map[molePositionRow - 1, molePositionCol] == '-')
                        {
                            map[molePositionRow, molePositionCol] = '-';
                            molePositionRow--;
                            map[molePositionRow, molePositionCol] = 'M';
                        }
                        else if (map[molePositionRow - 1, molePositionCol] == 'S')
                        {
                            points -= 3;
                            map[molePositionRow, molePositionCol] = '-';
                            molePositionRow--;
                            if (molePositionRow == firstTunnelRow && molePositionCol == firstTunnelCol)
                            {
                                map[molePositionRow, molePositionCol] = '-';
                                molePositionRow = secondTunnelRow;
                                molePositionCol = secondTunnelCol;
                                map[molePositionRow, molePositionCol] = 'M';
                            }
                            else if (molePositionRow == secondTunnelRow && molePositionCol == secondTunnelCol)
                            {
                                map[molePositionRow, molePositionCol] = '-';
                                molePositionRow = firstTunnelRow;
                                molePositionCol = firstTunnelCol;
                                map[molePositionRow, molePositionCol] = 'M';
                            }
                        }
                        else if(char.IsDigit(map[molePositionRow - 1, molePositionCol]))
                        {
                            map[molePositionRow, molePositionCol] = '-';
                            molePositionRow--;
                            int currentpoints = int.Parse(map[molePositionRow, molePositionCol].ToString());
                            points += currentpoints;
                            map[molePositionRow, molePositionCol] = 'M';

                            if (points >= 25)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                    }
                }
                else if (command == "right")
                {
                    if (IndexChecker(molePositionRow, molePositionCol)
                        && IndexChecker(molePositionRow, molePositionCol + 1))
                    {
                        if (map[molePositionRow, molePositionCol + 1] == '-')
                        {
                            map[molePositionRow, molePositionCol] = '-';
                            molePositionCol++;
                            map[molePositionRow, molePositionCol] = 'M';
                        }
                        else if (map[molePositionRow, molePositionCol + 1] == 'S')
                        {
                            points -= 3;
                            map[molePositionRow, molePositionCol] = '-';
                            molePositionCol++;
                            if (molePositionRow == firstTunnelRow && molePositionCol == firstTunnelCol)
                            {
                                map[molePositionRow, molePositionCol] = '-';
                                molePositionRow = secondTunnelRow;
                                molePositionCol = secondTunnelCol;
                                map[molePositionRow, molePositionCol] = 'M';
                            }
                            else if (molePositionRow == secondTunnelRow && molePositionCol == secondTunnelCol)
                            {
                                map[molePositionRow, molePositionCol] = '-';
                                molePositionRow = firstTunnelRow;
                                molePositionCol = firstTunnelCol;
                                map[molePositionRow, molePositionCol] = 'M';
                            }
                        }
                        else if (char.IsDigit(map[molePositionRow, molePositionCol + 1]))
                        {
                            map[molePositionRow, molePositionCol] = '-';
                            molePositionCol++;
                            int currentpoints = int.Parse(map[molePositionRow, molePositionCol].ToString());
                            points += currentpoints;
                            map[molePositionRow, molePositionCol] = 'M';

                            if (points >= 25)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                    }
                }
                else if (command == "down")
                {
                    if (IndexChecker(molePositionRow, molePositionCol)
                        && IndexChecker(molePositionRow + 1, molePositionCol))
                    {
                        if (map[molePositionRow + 1, molePositionCol] == '-')
                        {
                            map[molePositionRow, molePositionCol] = '-';
                            molePositionRow++;
                            map[molePositionRow, molePositionCol] = 'M';
                        }
                        else if (map[molePositionRow + 1, molePositionCol] == 'S')
                        {
                            points -= 3;
                            map[molePositionRow, molePositionCol] = '-';
                            molePositionRow++;
                            if (molePositionRow == firstTunnelRow && molePositionCol == firstTunnelCol)
                            {
                                map[molePositionRow, molePositionCol] = '-';
                                molePositionRow = secondTunnelRow;
                                molePositionCol = secondTunnelCol;
                                map[molePositionRow, molePositionCol] = 'M';
                            }
                            else if (molePositionRow == secondTunnelRow && molePositionCol == secondTunnelCol)
                            {
                                map[molePositionRow, molePositionCol] = '-';
                                molePositionRow = firstTunnelRow;
                                molePositionCol = firstTunnelCol;
                                map[molePositionRow, molePositionCol] = 'M';
                            }
                        }
                        else if(char.IsDigit(map[molePositionRow + 1, molePositionCol]))
                        {
                            map[molePositionRow, molePositionCol] = '-';
                            molePositionRow++;
                            int currentpoints = int.Parse(map[molePositionRow, molePositionCol].ToString());
                            points += currentpoints;
                            map[molePositionRow, molePositionCol] = 'M';

                            if (points >= 25)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                    }
                }
                else if (command == "left")
                {
                    if (IndexChecker(molePositionRow, molePositionCol)
                        && IndexChecker(molePositionRow, molePositionCol - 1))
                    {
                        if (map[molePositionRow, molePositionCol - 1] == '-')
                        {
                            map[molePositionRow, molePositionCol] = '-';
                            molePositionCol--;
                            map[molePositionRow, molePositionCol] = 'M';
                        }
                        else if (map[molePositionRow, molePositionCol - 1] == 'S')
                        {
                            points -= 3;
                            map[molePositionRow, molePositionCol] = '-';
                            molePositionCol--;
                            if (molePositionRow == firstTunnelRow && molePositionCol == firstTunnelCol)
                            {
                                map[molePositionRow, molePositionCol] = '-';
                                molePositionRow = secondTunnelRow;
                                molePositionCol = secondTunnelCol;
                                map[molePositionRow, molePositionCol] = 'M';
                            }
                            else if (molePositionRow == secondTunnelRow && molePositionCol == secondTunnelCol)
                            {
                                map[molePositionRow, molePositionCol] = '-';
                                molePositionRow = firstTunnelRow;
                                molePositionCol = firstTunnelCol;
                                map[molePositionRow, molePositionCol] = 'M';
                            }
                        }
                        else if(char.IsDigit(map[molePositionRow, molePositionCol - 1]))
                        {
                            map[molePositionRow, molePositionCol] = '-';
                            molePositionCol--;
                            int currentpoints = int.Parse(map[molePositionRow, molePositionCol].ToString());
                            points += currentpoints;
                            map[molePositionRow, molePositionCol] = 'M';

                            if (points >= 25)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                    }
                }
            }

            if (hasWon)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {points} points.");
            }



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
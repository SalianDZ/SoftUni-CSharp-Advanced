using System;

namespace _02._Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] map = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string data = Console.ReadLine();
                data = data.Replace(" ", "");

                for (int col = 0; col < size; col++)
                {
                    map[row, col] = data[col];
                }
            }
            int blackTruffle = 0;
            int summerTruffle = 0;
            int whiteTruffle = 0;
            int boarTruffles = 0;

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Stop")
                {
                    break;
                }
                else if (command[0] == "Collect")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    if (IndexChecker(row, col))
                    {
                        if (map[row, col] == 'B')
                        {
                            blackTruffle++;
                            map[row, col] = '-';
                        }
                        else if (map[row, col] == 'S')
                        {
                            summerTruffle++;
                            map[row, col] = '-';
                        }
                        else if (map[row, col] == 'W')
                        {
                            whiteTruffle++;
                            map[row, col] = '-';
                        }
                    }
                }
                else if (command[0] == "Wild_Boar")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    string direction = command[3];

                    if (map[row, col] == 'B' || map[row, col] == 'S' || map[row, col] == 'W')
                    {
                        map[row, col] = '-';
                        boarTruffles++;
                    }

                    if (direction == "up")
                    {
                        while (IndexChecker(row - 2, col))
                        {
                            row -= 2;
                            if (map[row, col] == 'B' || map[row, col] == 'S' || map[row, col] == 'W')
                            {
                                map[row, col] = '-';
                                boarTruffles++;
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        while (IndexChecker(row, col + 2))
                        {
                            col += 2;
                            if (map[row, col] == 'B' || map[row, col] == 'S' || map[row, col] == 'W')
                            {
                                map[row, col] = '-';
                                boarTruffles++;
                            }
                        }
                    }
                    else if (direction == "down")
                    {
                        while (IndexChecker(row + 2, col))
                        {
                            row += 2;
                            if (map[row, col] == 'B' || map[row, col] == 'S' || map[row, col] == 'W')
                            {
                                map[row, col] = '-';
                                boarTruffles++;
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        while (IndexChecker(row, col - 2))
                        {
                            col -= 2;
                            if (map[row, col] == 'B' || map[row, col] == 'S' || map[row, col] == 'W')
                            {
                                map[row, col] = '-';
                                boarTruffles++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Peter manages to harvest {blackTruffle} black, {summerTruffle} summer, and {whiteTruffle} white truffles.");
            Console.WriteLine($"The wild boar has eaten {boarTruffles} truffles.");
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

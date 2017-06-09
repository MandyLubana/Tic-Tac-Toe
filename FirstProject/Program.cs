using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[3, 3];
            Console.WriteLine("1 2 3\n4 5 6\n7 8 9");
            int choice = 0;
            for (int turn = 0; turn < 9; turn++)
            {
                //Print
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        Console.Write(board[row, col]);
                    }
                    Console.WriteLine("\n");
                }

                if (turn % 2 == 0)
                {
                    Console.WriteLine("\nPlayer 1 (X) your turn!");
                    Console.WriteLine("Please do select a position:");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            board[0, 0] = "x";
                            break;
                        case 2:
                            board[0, 1] = "x";
                            break;
                        case 3:
                            board[0, 2] = "x";
                            break;
                        case 4:
                            board[1, 0] = "x";
                            break;
                        case 5:
                            board[1, 1] = "x";
                            break;
                        case 6:
                            board[1, 2] = "x";
                            break;
                        case 7:
                            board[2, 0] = "x";
                            break;
                        case 8:
                            board[2, 1] = "x";
                            break;
                        case 9:
                            board[2, 2] = "x";
                            break;
                        default:
                            break;
                    }
                }
                else {
                    Console.WriteLine("\nPlayer 2 (0) your turn!");
                    Console.WriteLine("Please do select a position:");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            board[0, 0] = "o";
                            break;
                        case 2:
                            board[0, 1] = "o";
                            break;
                        case 3:
                            board[0, 2] = "o";
                            break;
                        case 4:
                            board[1, 0] = "o";
                            break;
                        case 5:
                            board[1, 1] = "o";
                            break;
                        case 6:
                            board[1, 2] = "o";
                            break;
                        case 7:
                            board[2, 0] = "o";
                            break;
                        case 8:
                            board[2, 1] = "o";
                            break;
                        case 9:
                            board[2, 2] = "o";
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

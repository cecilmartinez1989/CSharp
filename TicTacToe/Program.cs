using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        public static string[,] board;
        public static bool xturn = true;
        public static string winner;
        static void Main(string[] args)
        {
            board = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = " ";
                }
            }

            while (true)
            { printboard();
                Console.WriteLine("Enter the row and coloumn");
                string input = Console.ReadLine();
                string[] rawmove = input.Split(' ');
                int[] move = new int[2];
                move[0] = Convert.ToInt32(rawmove[0]) - 1;
                move[1] = Convert.ToInt32(rawmove[1]) - 1;
                placemark(move);
                if (checkwin())
                {
                    break;
                }
            }
            printboard();
            Console.WriteLine("Winner is "+ winner);

        }
        public static void printboard()
        {
            Console.WriteLine("  1  2  3 ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{board[i, j]}]");
                }
                Console.WriteLine();
            }


        }

        public static void placemark(int[] move)
        {
            if (board[move[0], move[1]] == " ")
            {
                if (xturn)
                {
                    board[move[0], move[1]] = "X";
                }
                else
                {
                    board[move[0], move[1]] = "O";
                }
                xturn = !xturn;
            }

        }
        public static bool checkwin()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                count = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == "X")
                    {
                        count++;
                    }
                    if (board[i, j] == "O")
                    {
                        count--;
                    }
                }
                if (count == 3)
                {
                    winner = "X";
                    return true;
                }
                if (count == -3)
                {
                    winner = "O";
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                count = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (board[j, i] == "X")
                    {
                        count++;
                    }
                    if (board[j, i] == "O")
                    {
                        count--;
                    }
                }
                if (count == 3)
                {
                    winner = "X";
                    return true;
                }
                if (count == -3)
                {
                    winner = "O";
                    return true;
                }
            }
            if(board[0,0]!= " "&& board[0,0]==board[1,1]&& board[1,1]==board[2,2])
            {
             if (board[1, 1] == "X")
                {
                    winner = "X";
                    return true;
                }
                if (board[1, 1] == "O")
                {
                    winner = "O";
                    return true;
                }
            }
            if (board[0, 2] != " " && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                if (board[1, 1] == "X")
                {
                    winner = "X";
                    return true;
                }
                if (board[1, 1] == "O")
                {
                    winner = "O";
                    return true;
                }
            }
            return false;
        }



            
    
        

    }
}

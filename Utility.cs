using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Utility
    {
        public static string[][] createBoard()
        {
            string[][] board = new string[3][];
            board[0] = new string[3];
            board[1] = new string[3];
            board[2] = new string[3];  
            for (int i  = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    board[i][j] = " ";
                }
            }
            return board;
        }

        public static void display(string[][] board)
        {
            Console.WriteLine("       0       1       2");
            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine("   +-------+-------+-------+");
                Console.WriteLine("   |       |       |       |");
                Console.WriteLine("   |       |       |       |");
                Console.WriteLine(" " + i + " |   " + board[i][0] + "   |   " + board[i][1] + "   |   " + board[i][2] + "   |");
                Console.WriteLine("   |       |       |       |");
                Console.WriteLine("   |       |       |       |");
                Console.WriteLine("   +-------+-------+-------+");
            }
        }

        public static Boolean boardFull(string[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == "X" || board[i][j] == "O") {
                        return false;
                    }
                }
            }
            return true;
        }

        public static Boolean gameWon(string[][] board, string value)
        {
            if (board[0][0].Equals(value) && board[0][1].Equals(value) && board[0][2].Equals(value)) { return true; }
            else if (board[1][0].Equals(value) && board[1][1].Equals(value) && board[1][2].Equals(value)) { return true; }
            else if (board[2][0].Equals(value) && board[2][1].Equals(value) && board[2][2].Equals(value)) { return true; }
            else if (board[0][0].Equals(value) && board[1][0].Equals(value) && board[2][0].Equals(value)) { return true; }
            else if (board[0][1].Equals(value) && board[1][1].Equals(value) && board[2][1].Equals(value)) { return true; }
            else if (board[0][2].Equals(value) && board[1][2].Equals(value) && board[2][2].Equals(value)) { return true; }
            else if (board[0][0].Equals(value) && board[1][1].Equals(value) && board[2][2].Equals(value)) { return true; }
            else if (board[0][2].Equals(value) && board[1][1].Equals(value) && board[2][0].Equals(value)) { return true; }
            else { return false; }
        }
    }
}

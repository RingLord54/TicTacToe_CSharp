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

        /// <summary>
        /// This method is used to ensure that if the 3x3 Board is filled up<br></br>
        /// then the game doesn't keep going and instead is ended and is marked<br></br>
        /// as a draw at that point.
        /// </summary>
        /// <param name="board"> The Game board </param>
        /// <returns>
        /// If the Board is full - return true<br></br>
        /// If the Board idn't full - return false
        /// </returns>
        public static Boolean boardFull(string[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] != "X" || board[i][j] != "O") {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// This method is used in order to check to see if either the Player<br></br>
        /// or the Opponent has won the game after a move is made. 
        /// </summary>
        /// <param name="board"> The Game Board </param>
        /// <param name="value"> Either "X" or "O", and used to check who's won</param>
        /// <returns>
        /// If the Player / Opponent has won - return true<br></br>
        /// If the Player / Opponent hasn't won - return false
        /// </returns>
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

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

        /// <summary>
        /// This method is used to display the 3x3 Game Board to the User<br></br>
        /// and updating it when spaces are filled in with either "X"s or "O"s
        /// </summary>
        /// <param name="board"> The Current Game Board </param>
        public static void display(string[][] board)
        {
            // Numbers added to indicate numerical values associated with the columns
            Console.WriteLine("       0       1       2");
            for (int i = 0; i < board.Length; i++)
            {
                // "i" is used on the 4th line to indicate the numerical values associated with the rows
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
        /// <param name="board"> The Current Game board </param>
        /// <returns>
        /// If the Board is full - return true<br></br>
        /// If the Board idn't full - return false
        /// </returns>
        public static Boolean boardFull(string[][] board)
        {
            // Loops through all of the nine board spaces
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    // If one of the spaces is empty (No X or O) then it's not full
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
        /// <param name="board"> The Current Game Board </param>
        /// <param name="value"> Either "X" or "O", and used to check who's won</param>
        /// <returns>
        /// If the Player / Opponent has won - return true<br></br>
        /// If the Player / Opponent hasn't won - return false
        /// </returns>
        public static Boolean gameWon(string[][] board, string value)
        {
            /* Checks all of the possible winning combinations against either the "X" character or the "O" character
             * depending on the value of the "value" parameter, and if a winning combination is found then it returns
             * true, meaning either the Player or Opponent has won the game
             */

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{

    /// <summary>
    /// This class contains all the code for the main TicTacToe Game<br></br>
    /// including some extra methods for User and Computer Turns
    /// </summary>

    internal class Game
    {
        public static void Main(string[] args)
        {
            string player, opponent, winner;
            Random rn = new Random();

            /* A While loop is used so that the Game can be played continuously after a game is
             * finished, unless the User decides not to play another Game after the finish one
             */
            while (true)
            {
                // Holds the newly created Game Board
                string[][] board = Game_Utility.CreateBoard();

                // Allows the User to choose if they wanted to be the Xs or the Os
                Console.Write("\nDo you want to be the Xs or the Os (\"O\"= Os, \"X\" = Xs): ");
                String choice = Console.ReadLine();

                if (choice.Equals("O") || choice.Equals("o"))
                {
                    player = "O";
                    opponent = "X";
                }
                else if (choice.Equals("X") || choice.Equals("x"))
                {
                    player = "X";
                    opponent = "O";
                }
                else
                {
                    // If Poor Data is entered
                    player = "X";    // By Default the User will be assigned X
                    opponent = "O";  // By Default the Computer will be assigned O
                }

                // Displays to the User what they are using and what the Computer is Using
                Console.WriteLine("You are using: " + player + "\nOpponent is using: " + opponent + "\n");
                Game_Utility.Display(board);

                while (true)
                {
                    PlayerTurn(board, player, opponent); // User's Turn
                    Game_Utility.Display(board); // Displays the Board
                    Boolean playerWon = Game_Utility.GameWon(board, player); // Checks to see if the User has won on their turn
                    // If the User did win they will be congratulated, and the Game ends
                    if (playerWon)
                    {
                        winner = "You are the winner! Congratulations";
                        break;
                    }

                    /* The Board is only checked to see if it's full after the User's turn
                     * because seeing as how the User goes first, then the situation of a full
                     * Board will only occur after the User's 5th Turn
                     */

                    // Board is checked after the User's Turn to see if the Board is full
                    Boolean isFull = Game_Utility.BoardFull(board);
                    // If the Board is full then the Game ends and it's marked as a draw
                    if (isFull)
                    {
                        winner = "Nobody won! It's a draw";
                        break;
                    }

                    OpponentTurn(board, player, opponent, rn); // Computer's Turn
                    Game_Utility.Display(board); // Displays the Board
                    Boolean opponentWon = Game_Utility.GameWon(board, opponent); // Checks to see if the Computer has won on its turn
                    // If the Computer did win, it will be congratulated and the Game ends
                    if (opponentWon)
                    {
                        winner = "The opponent is the winner! Better luck next time!";
                        break;
                    }
                }

                // Winning message is displayed
                Console.WriteLine("\n" + winner);
                Console.WriteLine("Thank you for playing the game!");

                // User is prompted if they want to play the Game again
                Console.WriteLine("\nDo you want to play again? \"Yes\" or \"No\": ");
                string select = Console.ReadLine();
                if (select.Equals("Yes") || select.Equals("yes")) 
                {
                    continue; // If the User says Yes, the Game will be played again
                }
                else if (select.Equals("No") || select.Equals("no")) 
                {
                    break; // If the User says No, then the Game Ends
                }
                else {
                    break; // By Default the Game will end
                }
            }
        }



        /// <summary>
        /// This method is called in order to have the User carry out their turn
        /// </summary>
        /// <param name="board"> The Current Game Board </param>
        /// <param name="player"> The User's Value being Used (X/O) </param>
        /// <param name="opponent"> The Computer's Value being Used (X/O) </param>
        public static void PlayerTurn(string[][] board, string player, string opponent)
        {
            // values for the row and column
            int row, column;

            /* A Do-While loop is used so that if the space on the board selected by the
             * User has already been used by the User themselves or by the Computer, then 
             * the User will have to enter another space on the board
             */
            do
            {
                Console.WriteLine("\nYour turn. Press any key to continue...");
                Console.ReadKey();
                Console.Write("\nEnter the row for your guess: ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the column for your guess: ");
                column = Convert.ToInt32(Console.ReadLine());

            } while (board[row][column] == player || board[row][column] == opponent);

            // Assigns the selected space on the Board with the User's Value.
            board[row][column] = player;
        }
        


        /// <summary>
        /// This method is called in order to have the Opponent (Computer) carry<br></br>
        /// out their turn in the Game.
        /// </summary>
        /// <param name="board"> The Current Game Board </param>
        /// <param name="player"> The User's Value being used (X/O) </param>
        /// <param name="opponent"> The Computer's Value being used (X/O) </param>
        /// <param name="rn"> Random variable used to select a random free space on the board</param>
        public static void OpponentTurn(string[][] board, string player, string opponent, Random rn)
        {
            // values for the row and column
            int OpRow, OpCol;

            // Displays to the User that it's the Computer's Turn
            Console.WriteLine("\nOpponent's turn. Press any key to continue...");
            Console.ReadKey();

            /* A Do-While loop is used so that if the randomly selected space on the board
             * has already been used by the User or by the Computer itself, then it will make
             * another random selection, until it selects one that's empty.
             */
            do
            {
                OpRow = rn.Next(0, 3);
                OpCol = rn.Next(0, 3);

            } while (board[OpRow][OpCol] == player || board[OpRow][OpCol] == opponent);

            // Assigns the selected space on the Board with the Computer's Value
            board[OpRow][OpCol] = opponent; 
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Game
    {
        public static void Main(string[] args)
        {
            string player, opponent, winner;
            Random rn = new Random();

            while (true)
            {
                string[][] board = Utility.CreateBoard();

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
                    player = "X";
                    opponent = "O";
                }

                Console.WriteLine("You are using: " + player + "\nOpponent is using: " + opponent + "\n");
                Utility.Display(board);

                while (true)
                {
                    PlayerTurn(board, player, opponent);
                    Utility.Display(board);
                    Boolean playerWon = Utility.GameWon(board, player);
                    if (playerWon)
                    {
                        winner = "You are the winner! Congratulations";
                        break;
                    }
                    Boolean isFull = Utility.BoardFull(board);
                    if (isFull)
                    {
                        winner = "Nobody won! It's a draw";
                        break;
                    }
                    OpponentTurn(board, player, opponent, rn);
                    Utility.Display(board);
                    Boolean opponentWon = Utility.GameWon(board, opponent);
                    if (opponentWon)
                    {
                        winner = "The opponent is the winner! Better luck next time!";
                        break;
                    }
                }
                Console.WriteLine("\n" + winner);
                Console.WriteLine("Thank you for playing the game!");
                Console.WriteLine("\nDo you want to play again? \"Yes\" or \"No\": ");
                string select = Console.ReadLine();
                if (select.Equals("Yes") || select.Equals("yes")) {
                    continue;
                }
                else if (select.Equals("No") || select.Equals("no")) {
                    break;
                }
                else {
                    break;
                }
            }
        }

        public static void PlayerTurn(string[][] board, string player, string opponent)
        {
            int row, column;
            do {
                Console.WriteLine("\nYour turn. Press any key to continue...");
                Console.ReadKey();
                Console.Write("\nEnter the row for your guess: ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the column for your guess: ");
                column = Convert.ToInt32(Console.ReadLine());
            } while (board[row][column] == player || board[row][column] == opponent);
            board[row][column] = player;
        }

        public static void OpponentTurn(string[][] board, string player, string opponent, Random rn)
        {
            int OpRow, OpCol;
            Console.WriteLine("\nOpponent's turn. Press any key to continue...");
            Console.ReadKey();
            do
            {
                OpRow = rn.Next(0, 3);
                OpCol = rn.Next(0, 3);
            } while (board[OpRow][OpCol] == player || board[OpRow][OpCol] == opponent);
            board[OpRow][OpCol] = opponent; 
        }
    }
}

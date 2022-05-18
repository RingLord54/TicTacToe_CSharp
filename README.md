# TicTacToe_CSharp

This game is a simple recreation of the game TicTacToe, where a three by three empty
board is drawn up and whoever is able to get three Xs or Os in a row first is the winner.




Pre-Game:
-------------------

You are given the option to choose as to whether you want to play as the Xs or play
as the Os.

- If the you enter either "x" or "X" you will use the Xs.
- If the you enter either "o" or "O" you will use the Os.
- If any other input is entered at this stage, then by default you will use the Xs.

- Naturally, the Computer will use the opposing choice to yours.




During the Game:
-------------------

When the game starts you get the first move. This means that you need to select a row
and a column in order to place down a counter. However, you cannot select a row or column
outside the given range, and you also cannot select a space that has already been filled in
by either you or the Computer.

After you make your move, the Computer makes its move by selecting a random spot on the board
to place its counter on. However, the same validation applies to the Computer where if the spot
selected has alreayd been filled in by either itself or you, then it will choose another.

After each turn made by the player and the Computer, the board is checked to see if anyone has won.
If someone has won, then the game ends and a winning message is displayed.

Furthermore, a method has been added to check to see if the board is full (all 9 spaces are full and
neither you or the computer has won - deadlock) in order to allow a draw to occur. This is mainly used
to prevent a deadlock situation where the game would continue but you can't make a move.




Post-Game:
-------------------

After the game has ended you have the choice as to whether or not you wish to play the game again.

- If you enter "yes" or "Yes" then you will play the game again.
- If you enter "no" or "No" then you will not play the game again.
- If any other input is entered at this stage, then the game will not be played again be default

If you decide not to play the game again, then a "Thank you for playing" message will be displayed





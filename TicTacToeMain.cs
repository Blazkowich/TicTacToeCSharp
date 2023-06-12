using System;
namespace TicTacToeMain
{
    class TicTacToe
    {
        public char[,] board;
        public char currentPlayer;
        public TicTacToe()
        {
            board = new char[3, 3];
            InitialiseBoard();
            currentPlayer = 'X';
        }

        public void InitialiseBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = '-';
                }
            }
        }

        public void Replace(int number)
        {
            if (number > 0 && number < 10)
            {
                int row = (number - 1) / 3;
                int col = (number - 1) % 3;


                if (board[row, col] == '-')
                {
                    board[row, col] = currentPlayer;
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                    Console.WriteLine();
                    Console.WriteLine($"It's Time For - {currentPlayer}");
                }
                else
                {
                    Console.WriteLine("Invalid move.");
                }
            }
            else
            {
                Console.WriteLine("Number Less than 1 or More than 9");
            }
        }

        public bool CheckWinner()
        {
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] != '-' && board[row, 0] == board[row, 1]
                    && board[row, 1] == board[row, 2])
                {   
                    return true;
                }
            }
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] != '-' && board[0, col] == board[1, col]
                    && board[1, col] == board[2, col])
                {
                    return true;
                }
            }
            if (board[0, 0] != '-' && board[0, 0] == board[1, 1]
                && board[1, 1] == board[2, 2])
            {
                return true;
            }
            if (board[0, 2] != '-' && board[0, 2] == board[1, 1]
                && board[1, 1] == board[2, 0])
            {
                return true;
            }
            return false;
        }   
    }
}

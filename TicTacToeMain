using System;
namespace TicTacToeMain
{
    class TicTacToe
    {
        public char[,] board;

        public TicTacToe()
        {
            board = new char[3, 3];
            InitialiseBoard();
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
                    board[row, col] = 'X';
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
    }
}

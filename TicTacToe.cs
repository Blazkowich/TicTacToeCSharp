using System;
using BoardViewerNameSpace;
using TicTacToeMain;
class Program
{
    static void Main(string[] args)
    {
        BoardViewer boardViewer = new();
        
        TicTacToe game = new TicTacToe();

        int c = 0;

        do
        {
            Console.WriteLine("Please Enter Number Between 1 - 9:");
            Console.WriteLine();
            Console.WriteLine(BoardViewer.DisplayBoard(game.board));

            try
            {
                int inp = int.Parse(Console.ReadLine());
                Console.WriteLine(game.Replace(inp));
                c++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input. Please enter a Integer");
            }

            if (game.CheckWinner())
            {
                Console.WriteLine();
                Console.WriteLine($"Game Won : {(game.currentPlayer == 'X' ? 'O': 'X')}");
            }

            if (c == 9 && game.CheckWinner() == false)
            {
                Console.WriteLine();
                Console.WriteLine("Draw!");
            }   
        }
        while (c < 10);
    }
}

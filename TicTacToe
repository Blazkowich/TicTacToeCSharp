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
            BoardViewer.DisplayBoard(game.board);
            int inp = int.Parse(Console.ReadLine());
            game.Replace(inp);
            c++;
        }

        while (c < 10);
    }
}

using System;
namespace BoardViewerNameSpace
{
    class BoardViewer
    {
        public static string DisplayBoard(char[,] board)
        {
            string formattedBoard = "";

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    formattedBoard += board[row, col] + " ";
                }
                formattedBoard += Environment.NewLine;
            }
            return formattedBoard;
        }
    }
}

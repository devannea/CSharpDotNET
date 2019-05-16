using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {

        static string CurrentPlayer = " ";
        const int BoardSize = 3;
        // initialize board
        static string[,] board = new string[BoardSize, BoardSize] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        // static int TotalMoves = 0;
        // static bool GameOver = false;

        static void Main(string[] args)
        {
            ResetBoard();
            StartGame();
            Console.Read();
        }

        #region Print the game board
        static void PrintBoard()
        {

            for (int j = 0; j < BoardSize; j++)
            {
                Console.WriteLine("-------"); // row guidelines
                for (int i = 0; i < BoardSize; i++)
                {
                    Console.Write("|" + board[i, j].ToString()); // column guidelines, write on one line, not writeline on separate lines
                }
                Console.WriteLine("|"); // closing board
            }
            Console.WriteLine("-------"); // closing board
            Console.Read();
        }
        #endregion

        static void PlaceMark(int RowPos, int ColPos)
        {
            int RowIdx = RowPos - 1;
            int ColIdx = ColPos - 1;
            board[RowIdx, ColIdx] = CurrentPlayer;
            PrintBoard();
        }

        public static void ResetBoard()
        {
            PrintBoard();
        }

        public static void StartGame()
        {
            PlaceMark();
        }

    }
}

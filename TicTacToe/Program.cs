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
        static string[,] board = new string[BoardSize, BoardSize] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } }; // initialize board
        static int TotalMoves = 0;
        static bool GameOver = false;

        static void Main(string[] args)
        {
            ResetBoard();
            StartGame();
            Console.Read();
        }

        public static void ResetBoard()
        {
            PrintBoard();
        }

        public static void StartGame()
        {
            PlaceMark();
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
            if (RowPos < 1 || RowPos > BoardSize || ColPos < 1 || ColPos > BoardSize)
            {
                Console.WriteLine($"Invalid row position or column position. Please check your input and try again.");
                return;
            }
            int RowIdx = RowPos - 1;
            int ColIdx = ColPos - 1;
            if (board[RowIdx, ColIdx] == " ")
            {
                board[RowIdx, ColIdx] = CurrentPlayer;
            }
            else
            {
                Console.WriteLine("That spot has already been marked. Please choose another spot.");
                StartGame();
            }
            TotalMoves++;
            //if (HasWon())
            //{
                //GameOver = true;
            //}
            //else if (IsTie())
            //{
                //GameOver = true;
            //}
            //else
            //{
                //if (CurrentPlayer == "X")
                //{
                    //CurrentPlayer = "O";
                //}
                //else
                //{
                    //CurrentPlayer = "X";
                //}
            //}
            //PrintBoard();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {

        static string[] squares = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static string currentPlayer = "O";
        static int moves = 0;

        static void Main(string[] args)
        {
            while(Win() == false && Tie() == false)
            {
                Console.Clear();
                printBoard();
                changeMarker();
                Console.WriteLine("Player " + currentPlayer + ", please select a square.");
                string input = Console.ReadLine();
                placeMark(input);
            }
            Console.Clear();
            printBoard();
            if(Win() == true && Tie() == false)
            {
                Console.WriteLine(currentPlayer + " wins!");
            } else if (Win() == false && Tie() == true)
            {
                Console.WriteLine("It's a tie.");
            }
            
            Console.Read();
        }

        // Print the game board
        static void printBoard()
        {
            Console.WriteLine("{0} | {1} | {2}", squares[1], squares[2], squares[3]);
            Console.WriteLine("---------");
            Console.WriteLine("{0} | {1} | {2}", squares[4], squares[5], squares[6]);
            Console.WriteLine("---------");
            Console.WriteLine("{0} | {1} | {2}", squares[7], squares[8], squares[9]);
        }

        // Place X or O
        static void placeMark(string input)
        {
            int XorO = Convert.ToInt32(input);
            squares[XorO] = currentPlayer;
            Win();
        }

        // Marker switches between X and O
        static void changeMarker()
        {
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
            }
            else
            {
                currentPlayer = "X";
            }
            moves++;
        }

        // If you get three in a row
        static bool RowWin()
        {
            if (squares[1] == squares[2] && squares[2] == squares[3])
            {
                return true;
            } else if (squares[4] == squares[5] && squares[5] == squares[6])
            {
                return true;
            } else if (squares[7] == squares[8] && squares[8] == squares[9])
            {
                return true;
            } else
            {
                return false;
            }
        }
        
        // If you get three in a column
        static bool ColumnWin()
        {
            if (squares[1] == squares[4] && squares[4] == squares[7])
            {
                return true;
            } else if (squares[2] == squares[5] && squares[5] == squares[8])
            {
                return true;
            } else if (squares[3] == squares[6] && squares[6] == squares[9])
            {
                return true;
            } else
            {
                return false;
            }
        }

        // If you get three diagnolly
        static bool DiagonalWin()
        {
            if (squares[1] == squares[5] && squares[5] == squares[9])
            {
                return true;
            } else if (squares[3] == squares[5] && squares[5] == squares[7])
            {
                return true;
            } else
            {
                return false;
            }
        }

        // Determine win
        static bool Win()
        {
            if (RowWin() == false && ColumnWin() == false && DiagonalWin() == false)
            {
                return false;
            } else
            {
                return true;
            }
        }

        // Determine tie
        static bool Tie()
        {
            if (Win() == false && moves == 9)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}

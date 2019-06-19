using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public struct Position
    {
        public int row { get; private set; }
        public int col { get; private set; }
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }

    public enum Color { White, Black }

    public class Checker
    {
        // Properties:
        public String Symbol { get; private set; } // open or a closed dot
        public Color Team { get; private set; } // team name (either "white" or "black")
        public Position Position { get; set; } // coordinates of its place on the grid
        // Constructor:
        public Checker(Color team, int row, int col)
        {
            Team = team;
            //Position = 
        }
        int openCircleId = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
        string openCircle = char.ConvertFromUtf32(openCircleId);

        //Console.WriteLine(openCircle);

        int closedCircleId = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
        string closedCircle = char.ConvertFromUtf32(closedCircleId);

        //Console.WriteLine(closedCircle);

    }

    public class Board
    {
        public List<Checker> checkers;
        public Board()
        {
            checkers = new List<Checker>();
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                    checkers.Add(c);
                }
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.Black, 5 + r, (r) % 2 + i);
                    checkers.Add(c);
                }
            }
        }

        public Checker GetChecker(Position pos)
        {
            //..
        }

        public void RemoveChecker(Checker checker)
        {
            // ...
        }

        public void MoveChecker(Checker checker, Position dest)
        {
            // ..
        }

    }

    public class Game
    {
        private Board board;
        public Game()
        {
            this.board = new Board();
        }

        private bool CheckForWin()
        {
            // ..
        }

        public void Start()
        {
            // ...
        }

        public bool IsLegalMove(Color player, Position src, Position dest)
        {
            // ...        
        }

        public bool IsCapture(Position src, Position dest)
        {
            // ...
        }

        public Checker GetCaptureChecker(Position src, Position dest)
        {
            // ..

        }

        public Position ProcessInput()
        {
            // ...
        }

        public void DrawBoard()
        {
            String[][] grid = new String[8][];
            for (int r = 0; r < 8; r++)
            {
                grid[r] = new String[8];
                for (int c = 0; c < 8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach (Checker c in board.checkers)
            {
                grid[c.Position.row][c.Position.col] = c.Symbol;
            }

            Console.WriteLine("  0 1 2 3 4 5 6 7");
            for (int r = 0; r < 8; r++)
            {
                Console.Write(r);
                for (int c = 0; c < 8; c++)
                {
                    Console.Write(" {0}", grid[r][c]);
                }
                Console.WriteLine();
            }
        }


    }

    class Program
    {
        public static void Main(String[] args)
        {
            Game game = new Game();
            game.Start();
        }
    }
}

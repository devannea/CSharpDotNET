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
            if (team == Color.Black)
            {
                int symbol = int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
                Symbol = char.ConvertFromUtf32(symbol);
                Team = Color.Black;
            }
            else
            {
                int symbol = int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
                Symbol = char.ConvertFromUtf32(symbol);
                Team = Color.White;
            }
            Position = new Position(row, col);
        }
    }

    public class Board
    {
        public List<Checker> checkers { get; private set; }
        public Board()
        {
            checkers = new List<Checker>();
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < 8; i += 2)
                {
                    // the first three rows are for White checkers (row = 0,1,2)
                    Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                    checkers.Add(c);
                }
                for (int i = 0; i < 8; i += 2)
                {
                    // the last three rows are for Black checkers (row=5,6,7)
                    Checker c = new Checker(Color.Black, (r + 5), r % 2 + i);
                    checkers.Add(c);
                }

            }
        }

        public Checker GetChecker(Position pos)
        {
            foreach (Checker c in checkers)
            {
                if (c.Position.row == pos.row && c.Position.col == pos.col)
                {
                    return c;
                }
            }
            return null;
        }

        public void RemoveChecker(Checker checker)
        {
            if (checker != null)
            {
                checkers.Remove(checker);
            }
        }

        public void MoveChecker(Checker checker, Position dest)
        {
            Checker c = new Checker(checker.Team, dest.row, dest.col);
            checkers.Add(c);
            checkers.Remove(checker);
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
            return (board.checkers.All(x => x.Team == Color.White) || board.checkers.All(x => x.Team == Color.Black));
        }

        public void Start()
        {
            DrawBoard();
            while (!CheckForWin()) ;
            {
                ProcessInput();
            }

            Console.WriteLine("Congrats, you win!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public bool IsLegalMove(Color player, Position src, Position dest)
        {
            if (src.row < 0 || src.row > 7 || src.col < 0 || src.col > 7
                || dest.row < 0 || dest.row > 7 || dest.col < 0
                || dest.col > 7) return false;

            int rowDistance = Math.Abs(dest.row - src.row);
            int colDistance = Math.Abs(dest.col - src.col);

            if (colDistance == 0 || rowDistance == 0) return false;

            if (rowDistance / colDistance != 1) return false;

            if (rowDistance > 2) return false;

            Checker c = board.GetChecker(src);
            if (c == null) 
            {
                return false;
            }

            c = board.GetChecker(dest);
            if (c != null) 
            {
                return false;
            }
            if (rowDistance == 2)
            {
                if (IsCapture(src, dest))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public bool IsCapture(Position src, Position dest)
        {
            int rowDistance = Math.Abs(dest.row - src.row);
            int colDistance = Math.Abs(dest.col - src.col);
            if (rowDistance == 2 && colDistance == 2)
            {
                int row_mid = (dest.row + src.row) / 2;
                int col_mid = (dest.col + src.col) / 2;
                Position p = new Position(row_mid, col_mid);
                Checker c = board.GetChecker(p);
                Checker player = board.GetChecker(src);
                if (c == null)
                {
                    return false;
                }
                else
                {
                    if (c.Team == player.Team)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public Checker GetCaptureChecker(Position src, Position dest)
        {
            if (IsCapture(src, dest))
            {
                int row_mid = (dest.row + src.row) / 2;
                int col_mid = (dest.col + src.col) / 2;
                Position p = new Position(row_mid, col_mid);
                Checker c = board.GetChecker(p);
                return c;
            }
            return null;
        }

        public void ProcessInput()
        {
            Console.WriteLine("Select a checker to move (Row, Column):");
            string[] src = Console.ReadLine().Split(',');
            Console.WriteLine("Select a square to move to (Row, Column):");
            string[] dest = Console.ReadLine().Split(',');
            
            Position from = new Position(int.Parse(src[0]), int.Parse(src[1]));
            Position to = new Position(int.Parse(dest[0]), int.Parse(dest[1]));

            Checker PlayerChecker = board.GetChecker(from);

            if (PlayerChecker == null)
            {
                Console.WriteLine("There is no checker there, try again");
                return;
            }
            else
            {
                if (this.IsLegalMove(PlayerChecker.Team, from, to))
                {
                    if (this.IsCapture(from, to)) ;
                    {
                        Checker captureChecker = this.GetCaptureChecker(from, to);
                        board.RemoveChecker(captureChecker);
                    }

                    board.MoveChecker(PlayerChecker, to);
                }
                else
                {
                    Console.WriteLine("This move is not valid, please try again.");
                    return;
                }
            }
            DrawBoard();
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

            Console.WriteLine("   0   1   2   3   4   5   6   7");
            Console.Write("  ");
            for (int i = 0; i < 32; i++)
            {
                Console.Write("\u2501");
            }
            Console.WriteLine();

            for (int r = 0; r < 8; r++)
            {
                Console.Write($"{r} ");
                for (int c = 0; c < 8; c++)
                {
                    Console.Write($" {grid[r][c]} \u2503");
                }
                Console.WriteLine();
                Console.Write("  ");
                for (int i = 0; i < 32; i++)
                {
                    Console.Write("\u2501");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Game newGame = new Game();
            newGame.Start();
            Console.ReadKey();
        }
    }
}

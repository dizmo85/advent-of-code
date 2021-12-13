using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using advent_of_code;

namespace advent_of_code.day04
{
    internal class Day04
    {
        private List<BingoBoard> SetUpGame(string[] input)
        {
            List<BingoBoard> boards = new List<BingoBoard>();

            int i = 2;
            while (i < input.Length)
            {
                BingoBoard board = new BingoBoard();
                board.SetGrid
                (
                    new string[] { input[i], input[i+1], input[i+2], input[i+3], input[i+4] }
                );
                boards.Add(board);

                i+=6;
            }

            return boards;
        }

        public int SquidBingo()
        {
            string[] input = Utilities.ReadFileToArray(4);
            string[] balls = input[0].Split(',');
            List<BingoBoard> boards = SetUpGame(input);

            foreach (string ball in balls)
            {
                foreach (BingoBoard board in boards)
                {
                    if (board.CheckBoard(ball))
                    {
                        return board.Score(ball);
                    }
                }
            }

            return 0;
        }

        public int LastToWin()
        {
            string[] input = Utilities.ReadFileToArray(4);
            string[] balls = input[0].Split(',');
            List<BingoBoard> boards = SetUpGame(input);

            foreach (string ball in balls)
            {
                for (int i = 0; i < boards.Count; i++)
                {
                    if (boards.Count > 1 && boards[i].CheckBoard(ball))
                    {
                        boards.Remove(boards[i]);
                        i--;
                    }
                    else if (boards[i].CheckBoard(ball) && boards.Count == 1)
                        return boards[i].Score(ball);
                }
            }

            return 0;
        }
    }

    class BingoBoard
    {
        int[] rowHits = new int[5];
        int[] colHits = new int[5];
        string[][] grid = new string[5][];

        public int[] RowHits { get { return rowHits; } }
        public int[] ColHits { get { return colHits; } }

        public string[][] Grid
        {
            get => grid;
            set
            {
                for (int i = 0; i<value.Length; i++)
                {

                }
            }
        }

        public void SetGrid(string[] input)
        {
            for (int i = 0; i<input.Length; i++)
            {
                grid[i] = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        public bool CheckBoard(string number)
        {
            for (int i = 0; i<grid.Length; i++)
            {
                for (int j = 0; j<grid[i].Length; j++)
                {
                    if (grid[i][j] == number)
                    {
                        rowHits[i]++;
                        colHits[j]++;
                        grid[i][j] = "X";
                    }

                    if (rowHits[i] == 5 || colHits[i] == 5)
                        return true;
                }
            }

            return false;
        }

        public int Score(string number)
        {
            int sum = 0;

            foreach (string[] row in grid)
            {
                foreach (string col in row)
                {
                    if (col != "X")
                        sum += Convert.ToInt32(col);
                }
            }

            return sum * Convert.ToInt32(number);
        }
    }
}

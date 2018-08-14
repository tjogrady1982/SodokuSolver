using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class RuleCheck
    {
        public const int BoardDimensions = 9; //used for height and width of board

        public void Solve(int[,] boardData) //attempt to solve the board
        {
            this.SolveInternal(boardData);
            Console.WriteLine(boardData);
        }

        private bool SolveInternal(int[,] boardData) //instigates the solution search
        {
            for (int ix = 0; ix < BoardDimensions; ix++)
            {
                for (int iy = 0; iy < BoardDimensions; iy++)
                {
                    if (boardData[ix, iy] == 0)
                    {
                        return this.SolveCell(boardData, ix, iy);
                    }
                }
            }

            return true;
        }

        private bool SolveCell(int[,] boardData, int x, int y) // try values in first cell then check if criteria are passed
        {
            for (int testVal = 1; testVal <= 9; testVal++)
            {
                if (AllRulesPassed(boardData, testVal, x, y))
                {
                    boardData[x, y] = testVal;
                    if (this.SolveInternal(boardData))
                    {
                        return true;
                    }
                }
            }

            // failed to find a solution on this path. So abort
            boardData[x, y] = 0;
            return false;
        }

        private static bool AllRulesPassed(int[,] boardData, int val, int x, int y)
        {
            return
              UniqueInRow(boardData, val, x, y) &&
              UniqueInCol(boardData, val, x, y) &&
              UniqueInSubGrid(boardData, val, x, y);
        }

        private static bool UniqueInRow(int[,] boardData, int val, int x, int y)
        {
            bool result = true;
            for (int i = 0; i < BoardDimensions; i++)
            {
                if ((i != x) && (boardData[i, y] == val))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private static bool UniqueInCol(int[,] boardData, int val, int x, int y)
        {
            bool result = true;
            for (int i = 0; i < BoardDimensions; i++)
            {
                if ((i != y) && (boardData[x, i] == val))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
        private static bool UniqueInSubGrid(int[,] boardData, int val, int x, int y)
        {
            bool result = true;

            const int SubGrid = BoardDimensions / 3;
            int startx = x / 3;
            startx = startx * 3;
            int starty = y / 3;
            starty = starty * 3;

            for (int ix = startx; ix < startx + SubGrid; ix++)
            {
                for (int iy = starty; iy < starty + SubGrid; iy++)
                {
                    if ((ix != x) && (iy != y) && (boardData[ix, iy] == val))
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }




    }
}
